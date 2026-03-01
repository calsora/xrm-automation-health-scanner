using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace XrmAutomationHealthScannerPlugin
{
    public partial class MyPluginControl : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        private Settings mySettings;

        public string RepositoryName => "test";
        public string UserName => "calsora";
        public string HelpUrl => "http://www.google.com";

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }

            // disable controls
            SetControlEnabled(false);
        }


        private void SetControlEnabled(bool isEnabled)
        {
            groupBox1.Enabled = isEnabled;

            foreach (var cb in new[] { workflowscheckBox, bizrulescheckBox, cloudflowscheckBox })
            {
                cb.Enabled = groupBox1.Enabled;
            }

            nameSearchInput.Enabled = isEnabled;
        }


        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        // Loads all deactivated workflows (statecode = 1) and binds a simple projection to the grid
        private void LoadDisabledAutomations()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting disabled workflows",
                Work = (worker, args) =>
                {
                    var query = new QueryExpression("workflow")
                    {
                        ColumnSet = new ColumnSet("name", "createdon", "createdby", "modifiedon", "modifiedby", "category"),
                        Orders = { new OrderExpression("name", OrderType.Ascending) },
                        PageInfo = new PagingInfo { Count = 5000, PageNumber = 1 }
                    };

                    var selectedCategories = new List<int>();

                    foreach (var cb in new[] { workflowscheckBox, bizrulescheckBox, cloudflowscheckBox })
                    {
                        if (cb.Checked && cb.Tag != null)
                        {
                            if (int.TryParse(cb.Tag.ToString(), out int categoryValue))
                            {
                                selectedCategories.Add(categoryValue);
                            }
                        }
                    }

                    query.Criteria.AddCondition("statecode", ConditionOperator.Equal, 0);
                    query.Criteria.AddCondition("ismanaged", ConditionOperator.Equal, false);
                    if (selectedCategories.Any())
                    {
                        query.Criteria.AddCondition("category", ConditionOperator.In, selectedCategories.Cast<object>().ToArray());
                    }

                    string nameSearchInputValue = nameSearchInput.Text.Trim().ToLower();

                    if (!string.IsNullOrWhiteSpace(nameSearchInputValue))
                    {
                        query.Criteria.AddCondition("name", ConditionOperator.BeginsWith, nameSearchInputValue);
                    }


                    var all = new List<Entity>();
                    while (true)
                    {
                        var page = Service.RetrieveMultiple(query);
                        all.AddRange(page.Entities);
                        if (!page.MoreRecords) break;
                        query.PageInfo.PageNumber++;
                        query.PageInfo.PagingCookie = page.PagingCookie;
                    }

                    args.Result = all;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var entities = args.Result as List<Entity> ?? new List<Entity>();

                    var rows = entities.Select(x => new
                    {
                        Name = x.GetAttributeValue<string>("name"),
                        CreatedOn = x.GetAttributeValue<DateTime?>("createdon"),
                        CreatedBy = x.GetAttributeValue<EntityReference>("createdby")?.Name,
                        ModifiedOn = x.GetAttributeValue<DateTime?>("modifiedon"),
                        ModifiedBy = x.GetAttributeValue<EntityReference>("modifiedby")?.Name,
                        Category = x.FormattedValues.Contains("category") ? x.FormattedValues["category"] : x.GetAttributeValue<OptionSetValue>("category")?.Value.ToString(),

                    }).ToList();

                    crmGridView2.AutoGenerateColumns = true;
                    crmGridView2.DataSource = rows;
                    crmGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    crmGridView2.Refresh();
                }
            });

            SetControlEnabled(true);

        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }

            // Ensure the grid has the current service so it can be used if needed by the grid control
            crmGridView2.OrganizationService = newService;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure connection and then load disabled automations
            ExecuteMethod(LoadDisabledAutomations);
        }

        private void textBoxWithPlaceholder1_TextChanged(object sender, EventArgs e)
        {
            ExecuteMethod(LoadDisabledAutomations);

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}