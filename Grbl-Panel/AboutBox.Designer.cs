using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    [DesignerGenerated()]
    public partial class AboutBox : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        private GroupBox GroupBox1;
        private RichTextBox _MoreRichTextBox;

        internal RichTextBox MoreRichTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MoreRichTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MoreRichTextBox != null)
                {
                    _MoreRichTextBox.LinkClicked -= MoreRichTextBox_LinkClicked;
                }

                _MoreRichTextBox = value;
                if (_MoreRichTextBox != null)
                {
                    _MoreRichTextBox.LinkClicked += MoreRichTextBox_LinkClicked;
                }
            }
        }

        internal ListView AppInfoListView;
        internal ColumnHeader colKey;
        internal ColumnHeader colValue;
        private ListView _AssemblyInfoListView;

        internal ListView AssemblyInfoListView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AssemblyInfoListView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AssemblyInfoListView != null)
                {
                    _AssemblyInfoListView.DoubleClick -= AssemblyInfoListView_DoubleClick;
                    _AssemblyInfoListView.ColumnClick -= AssemblyInfoListView_ColumnClick;
                }

                _AssemblyInfoListView = value;
                if (_AssemblyInfoListView != null)
                {
                    _AssemblyInfoListView.DoubleClick += AssemblyInfoListView_DoubleClick;
                    _AssemblyInfoListView.ColumnClick += AssemblyInfoListView_ColumnClick;
                }
            }
        }

        internal ColumnHeader colAssemblyName;
        internal ColumnHeader colAssemblyVersion;
        internal ColumnHeader colAssemblyBuilt;
        internal ColumnHeader colAssemblyCodeBase;
        private TabControl _TabPanelDetails;

        internal TabControl TabPanelDetails
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabPanelDetails;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabPanelDetails != null)
                {
                    _TabPanelDetails.SelectedIndexChanged -= TabPanelDetails_SelectedIndexChanged;
                }

                _TabPanelDetails = value;
                if (_TabPanelDetails != null)
                {
                    _TabPanelDetails.SelectedIndexChanged += TabPanelDetails_SelectedIndexChanged;
                }
            }
        }

        internal TabPage TabPageApplication;
        internal TabPage TabPageAssemblies;
        internal TabPage TabPageAssemblyDetails;
        internal ListView AssemblyDetailsListView;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        private ComboBox _AssemblyNamesComboBox;

        internal ComboBox AssemblyNamesComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AssemblyNamesComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AssemblyNamesComboBox != null)
                {
                    _AssemblyNamesComboBox.SelectedIndexChanged -= AssemblyNamesComboBox_SelectedIndexChanged;
                }

                _AssemblyNamesComboBox = value;
                if (_AssemblyNamesComboBox != null)
                {
                    _AssemblyNamesComboBox.SelectedIndexChanged += AssemblyNamesComboBox_SelectedIndexChanged;
                }
            }
        }

        private Button OKButton;
        private Label AppTitleLabel;
        private Label AppDescriptionLabel;
        private Label AppVersionLabel;
        private Label AppCopyrightLabel;
        private Button _SysInfoButton;

        private Button SysInfoButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SysInfoButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SysInfoButton != null)
                {
                    _SysInfoButton.Click -= SysInfoButton_Click;
                }

                _SysInfoButton = value;
                if (_SysInfoButton != null)
                {
                    _SysInfoButton.Click += SysInfoButton_Click;
                }
            }
        }

        private Label AppDateLabel;
        private PictureBox ImagePictureBox;
        private Button _DetailsButton;

        private Button DetailsButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DetailsButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DetailsButton != null)
                {
                    _DetailsButton.Click -= DetailsButton_Click;
                }

                _DetailsButton = value;
                if (_DetailsButton != null)
                {
                    _DetailsButton.Click += DetailsButton_Click;
                }
            }
        }

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            OKButton = new Button();
            AppTitleLabel = new Label();
            GroupBox1 = new GroupBox();
            AppDescriptionLabel = new Label();
            AppVersionLabel = new Label();
            AppCopyrightLabel = new Label();
            _SysInfoButton = new Button();
            _SysInfoButton.Click += new EventHandler(SysInfoButton_Click);
            AppDateLabel = new Label();
            ImagePictureBox = new PictureBox();
            _DetailsButton = new Button();
            _DetailsButton.Click += new EventHandler(DetailsButton_Click);
            _MoreRichTextBox = new RichTextBox();
            _MoreRichTextBox.LinkClicked += new LinkClickedEventHandler(MoreRichTextBox_LinkClicked);
            _TabPanelDetails = new TabControl();
            _TabPanelDetails.SelectedIndexChanged += new EventHandler(TabPanelDetails_SelectedIndexChanged);
            TabPageApplication = new TabPage();
            AppInfoListView = new ListView();
            colKey = new ColumnHeader();
            colValue = new ColumnHeader();
            TabPageAssemblies = new TabPage();
            _AssemblyInfoListView = new ListView();
            _AssemblyInfoListView.DoubleClick += new EventHandler(AssemblyInfoListView_DoubleClick);
            _AssemblyInfoListView.ColumnClick += new ColumnClickEventHandler(AssemblyInfoListView_ColumnClick);
            colAssemblyName = new ColumnHeader();
            colAssemblyVersion = new ColumnHeader();
            colAssemblyBuilt = new ColumnHeader();
            colAssemblyCodeBase = new ColumnHeader();
            TabPageAssemblyDetails = new TabPage();
            AssemblyDetailsListView = new ListView();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            _AssemblyNamesComboBox = new ComboBox();
            _AssemblyNamesComboBox.SelectedIndexChanged += new EventHandler(AssemblyNamesComboBox_SelectedIndexChanged);
            _btnAboutChanges = new Button();
            _btnAboutChanges.Click += new EventHandler(btnAboutChanges_Click);
            _btnAboutCredits = new Button();
            _btnAboutCredits.Click += new EventHandler(btnAboutCredits_Click);
            _btnAboutLicense = new Button();
            _btnAboutLicense.Click += new EventHandler(btnAboutLicense_Click);
            ((System.ComponentModel.ISupportInitialize)ImagePictureBox).BeginInit();
            _TabPanelDetails.SuspendLayout();
            TabPageApplication.SuspendLayout();
            TabPageAssemblies.SuspendLayout();
            TabPageAssemblyDetails.SuspendLayout();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OKButton.DialogResult = DialogResult.Cancel;
            OKButton.Location = new Point(482, 474);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(59, 23);
            OKButton.TabIndex = 1;
            OKButton.Text = "OK";
            // 
            // AppTitleLabel
            // 
            AppTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AppTitleLabel.Location = new Point(60, 8);
            AppTitleLabel.Name = "AppTitleLabel";
            AppTitleLabel.Size = new Size(496, 16);
            AppTitleLabel.TabIndex = 2;
            AppTitleLabel.Text = "%title%";
            // 
            // GroupBox1
            // 
            GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox1.Location = new Point(8, 48);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(548, 2);
            GroupBox1.TabIndex = 3;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "GroupBox1";
            // 
            // AppDescriptionLabel
            // 
            AppDescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AppDescriptionLabel.Location = new Point(60, 28);
            AppDescriptionLabel.Name = "AppDescriptionLabel";
            AppDescriptionLabel.Size = new Size(496, 16);
            AppDescriptionLabel.TabIndex = 4;
            AppDescriptionLabel.Text = "%description%";
            // 
            // AppVersionLabel
            // 
            AppVersionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AppVersionLabel.Location = new Point(8, 60);
            AppVersionLabel.Name = "AppVersionLabel";
            AppVersionLabel.Size = new Size(548, 16);
            AppVersionLabel.TabIndex = 5;
            AppVersionLabel.Text = "Version %version%";
            // 
            // AppCopyrightLabel
            // 
            AppCopyrightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AppCopyrightLabel.Location = new Point(8, 100);
            AppCopyrightLabel.Name = "AppCopyrightLabel";
            AppCopyrightLabel.Size = new Size(548, 16);
            AppCopyrightLabel.TabIndex = 6;
            AppCopyrightLabel.Text = "Copyright © %year%, %trademark%";
            // 
            // SysInfoButton
            // 
            _SysInfoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _SysInfoButton.Location = new Point(395, 474);
            _SysInfoButton.Name = "_SysInfoButton";
            _SysInfoButton.Size = new Size(81, 23);
            _SysInfoButton.TabIndex = 7;
            _SysInfoButton.Text = "&System Info";
            _SysInfoButton.Visible = false;
            // 
            // AppDateLabel
            // 
            AppDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AppDateLabel.Location = new Point(8, 80);
            AppDateLabel.Name = "AppDateLabel";
            AppDateLabel.Size = new Size(548, 16);
            AppDateLabel.TabIndex = 8;
            AppDateLabel.Text = "Built on %builddate%";
            // 
            // ImagePictureBox
            // 
            ImagePictureBox.Location = new Point(16, 8);
            ImagePictureBox.Name = "ImagePictureBox";
            ImagePictureBox.Size = new Size(32, 32);
            ImagePictureBox.TabIndex = 9;
            ImagePictureBox.TabStop = false;
            // 
            // DetailsButton
            // 
            _DetailsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _DetailsButton.Location = new Point(406, 474);
            _DetailsButton.Name = "_DetailsButton";
            _DetailsButton.Size = new Size(59, 23);
            _DetailsButton.TabIndex = 10;
            _DetailsButton.Text = "&Details >>";
            // 
            // MoreRichTextBox
            // 
            _MoreRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _MoreRichTextBox.BackColor = SystemColors.ControlLight;
            _MoreRichTextBox.Location = new Point(8, 119);
            _MoreRichTextBox.Name = "_MoreRichTextBox";
            _MoreRichTextBox.ReadOnly = true;
            _MoreRichTextBox.Size = new Size(548, 347);
            _MoreRichTextBox.TabIndex = 13;
            _MoreRichTextBox.Text = "";
            _MoreRichTextBox.WordWrap = false;
            // 
            // TabPanelDetails
            // 
            _TabPanelDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _TabPanelDetails.Controls.Add(TabPageApplication);
            _TabPanelDetails.Controls.Add(TabPageAssemblies);
            _TabPanelDetails.Controls.Add(TabPageAssemblyDetails);
            _TabPanelDetails.Location = new Point(8, 119);
            _TabPanelDetails.Name = "_TabPanelDetails";
            _TabPanelDetails.SelectedIndex = 0;
            _TabPanelDetails.Size = new Size(546, 347);
            _TabPanelDetails.TabIndex = 15;
            _TabPanelDetails.Visible = false;
            // 
            // TabPageApplication
            // 
            TabPageApplication.Controls.Add(AppInfoListView);
            TabPageApplication.Location = new Point(4, 22);
            TabPageApplication.Name = "TabPageApplication";
            TabPageApplication.Size = new Size(538, 321);
            TabPageApplication.TabIndex = 0;
            TabPageApplication.Text = "Application";
            // 
            // AppInfoListView
            // 
            AppInfoListView.Columns.AddRange(new ColumnHeader[] { colKey, colValue });
            AppInfoListView.Dock = DockStyle.Fill;
            AppInfoListView.FullRowSelect = true;
            AppInfoListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            AppInfoListView.Location = new Point(0, 0);
            AppInfoListView.Name = "AppInfoListView";
            AppInfoListView.Size = new Size(538, 321);
            AppInfoListView.TabIndex = 16;
            AppInfoListView.UseCompatibleStateImageBehavior = false;
            AppInfoListView.View = View.Details;
            // 
            // colKey
            // 
            colKey.Text = "Application Key";
            colKey.Width = 120;
            // 
            // colValue
            // 
            colValue.Text = "Value";
            colValue.Width = 700;
            // 
            // TabPageAssemblies
            // 
            TabPageAssemblies.Controls.Add(_AssemblyInfoListView);
            TabPageAssemblies.Location = new Point(4, 22);
            TabPageAssemblies.Name = "TabPageAssemblies";
            TabPageAssemblies.Size = new Size(368, 121);
            TabPageAssemblies.TabIndex = 1;
            TabPageAssemblies.Text = "Assemblies";
            // 
            // AssemblyInfoListView
            // 
            _AssemblyInfoListView.Columns.AddRange(new ColumnHeader[] { colAssemblyName, colAssemblyVersion, colAssemblyBuilt, colAssemblyCodeBase });
            _AssemblyInfoListView.Dock = DockStyle.Fill;
            _AssemblyInfoListView.FullRowSelect = true;
            _AssemblyInfoListView.Location = new Point(0, 0);
            _AssemblyInfoListView.MultiSelect = false;
            _AssemblyInfoListView.Name = "_AssemblyInfoListView";
            _AssemblyInfoListView.Size = new Size(368, 121);
            _AssemblyInfoListView.Sorting = SortOrder.Ascending;
            _AssemblyInfoListView.TabIndex = 13;
            _AssemblyInfoListView.UseCompatibleStateImageBehavior = false;
            _AssemblyInfoListView.View = View.Details;
            // 
            // colAssemblyName
            // 
            colAssemblyName.Text = "Assembly";
            colAssemblyName.Width = 123;
            // 
            // colAssemblyVersion
            // 
            colAssemblyVersion.Text = "Version";
            colAssemblyVersion.Width = 100;
            // 
            // colAssemblyBuilt
            // 
            colAssemblyBuilt.Text = "Built";
            colAssemblyBuilt.Width = 130;
            // 
            // colAssemblyCodeBase
            // 
            colAssemblyCodeBase.Text = "CodeBase";
            colAssemblyCodeBase.Width = 750;
            // 
            // TabPageAssemblyDetails
            // 
            TabPageAssemblyDetails.Controls.Add(AssemblyDetailsListView);
            TabPageAssemblyDetails.Controls.Add(_AssemblyNamesComboBox);
            TabPageAssemblyDetails.Location = new Point(4, 22);
            TabPageAssemblyDetails.Name = "TabPageAssemblyDetails";
            TabPageAssemblyDetails.Size = new Size(368, 121);
            TabPageAssemblyDetails.TabIndex = 2;
            TabPageAssemblyDetails.Text = "Assembly Details";
            // 
            // AssemblyDetailsListView
            // 
            AssemblyDetailsListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader2 });
            AssemblyDetailsListView.Dock = DockStyle.Fill;
            AssemblyDetailsListView.FullRowSelect = true;
            AssemblyDetailsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            AssemblyDetailsListView.Location = new Point(0, 21);
            AssemblyDetailsListView.Name = "AssemblyDetailsListView";
            AssemblyDetailsListView.Size = new Size(368, 100);
            AssemblyDetailsListView.Sorting = SortOrder.Ascending;
            AssemblyDetailsListView.TabIndex = 19;
            AssemblyDetailsListView.UseCompatibleStateImageBehavior = false;
            AssemblyDetailsListView.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Assembly Key";
            ColumnHeader1.Width = 120;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "Value";
            ColumnHeader2.Width = 700;
            // 
            // AssemblyNamesComboBox
            // 
            _AssemblyNamesComboBox.Dock = DockStyle.Top;
            _AssemblyNamesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _AssemblyNamesComboBox.Location = new Point(0, 0);
            _AssemblyNamesComboBox.Name = "_AssemblyNamesComboBox";
            _AssemblyNamesComboBox.Size = new Size(368, 21);
            _AssemblyNamesComboBox.Sorted = true;
            _AssemblyNamesComboBox.TabIndex = 18;
            // 
            // btnAboutChanges
            // 
            _btnAboutChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnAboutChanges.Location = new Point(178, 474);
            _btnAboutChanges.Name = "_btnAboutChanges";
            _btnAboutChanges.Size = new Size(59, 23);
            _btnAboutChanges.TabIndex = 16;
            _btnAboutChanges.Text = "Changes";
            _btnAboutChanges.UseVisualStyleBackColor = true;
            // 
            // btnAboutCredits
            // 
            _btnAboutCredits.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnAboutCredits.Location = new Point(254, 474);
            _btnAboutCredits.Name = "_btnAboutCredits";
            _btnAboutCredits.Size = new Size(59, 23);
            _btnAboutCredits.TabIndex = 17;
            _btnAboutCredits.Text = "Credits";
            _btnAboutCredits.UseVisualStyleBackColor = true;
            // 
            // btnAboutLicense
            // 
            _btnAboutLicense.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnAboutLicense.Location = new Point(330, 474);
            _btnAboutLicense.Name = "_btnAboutLicense";
            _btnAboutLicense.Size = new Size(59, 23);
            _btnAboutLicense.TabIndex = 18;
            _btnAboutLicense.Text = "License";
            _btnAboutLicense.UseVisualStyleBackColor = true;
            // 
            // AboutBox
            // 
            AutoScaleBaseSize = new Size(5, 13);
            CancelButton = OKButton;
            ClientSize = new Size(564, 505);
            Controls.Add(_btnAboutLicense);
            Controls.Add(_btnAboutCredits);
            Controls.Add(_btnAboutChanges);
            Controls.Add(_DetailsButton);
            Controls.Add(ImagePictureBox);
            Controls.Add(AppDateLabel);
            Controls.Add(_SysInfoButton);
            Controls.Add(AppCopyrightLabel);
            Controls.Add(AppVersionLabel);
            Controls.Add(AppDescriptionLabel);
            Controls.Add(GroupBox1);
            Controls.Add(AppTitleLabel);
            Controls.Add(OKButton);
            Controls.Add(_MoreRichTextBox);
            Controls.Add(_TabPanelDetails);
            Font = new Font("Tahoma", 8.0f);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About %title%";
            ((System.ComponentModel.ISupportInitialize)ImagePictureBox).EndInit();
            _TabPanelDetails.ResumeLayout(false);
            TabPageApplication.ResumeLayout(false);
            TabPageAssemblies.ResumeLayout(false);
            TabPageAssemblyDetails.ResumeLayout(false);
            Load += new EventHandler(AboutBox_Load);
            Paint += new PaintEventHandler(AboutBox_Paint);
            ResumeLayout(false);
        }

        private Button _btnAboutChanges;

        internal Button btnAboutChanges
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAboutChanges;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAboutChanges != null)
                {
                    _btnAboutChanges.Click -= btnAboutChanges_Click;
                }

                _btnAboutChanges = value;
                if (_btnAboutChanges != null)
                {
                    _btnAboutChanges.Click += btnAboutChanges_Click;
                }
            }
        }

        private Button _btnAboutCredits;

        internal Button btnAboutCredits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAboutCredits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAboutCredits != null)
                {
                    _btnAboutCredits.Click -= btnAboutCredits_Click;
                }

                _btnAboutCredits = value;
                if (_btnAboutCredits != null)
                {
                    _btnAboutCredits.Click += btnAboutCredits_Click;
                }
            }
        }

        private Button _btnAboutLicense;

        internal Button btnAboutLicense
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAboutLicense;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAboutLicense != null)
                {
                    _btnAboutLicense.Click -= btnAboutLicense_Click;
                }

                _btnAboutLicense = value;
                if (_btnAboutLicense != null)
                {
                    _btnAboutLicense.Click += btnAboutLicense_Click;
                }
            }
        }
    }
}