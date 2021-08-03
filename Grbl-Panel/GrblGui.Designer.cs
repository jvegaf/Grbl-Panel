using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    [DesignerGenerated()]
    public partial class GrblGui : Form
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
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(GrblGui));
            MenuStrip1 = new MenuStrip();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            _ExitToolStripMenuItem = new ToolStripMenuItem();
            _ExitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);
            ToolsToolStripMenuItem = new ToolStripMenuItem();
            _OptionsToolStripMenuItem = new ToolStripMenuItem();
            _OptionsToolStripMenuItem.Click += new EventHandler(OptionsToolStripMenuItem_Click);
            HelpToolStripMenuItem = new ToolStripMenuItem();
            _AboutToolStripMenuItem = new ToolStripMenuItem();
            _AboutToolStripMenuItem.Click += new EventHandler(AboutToolStripMenuItem_Click);
            TabControl1 = new TabControl();
            tabPgInterface = new TabPage();
            gbOverrides = new GroupBox();
            _btnMistOverride = new Button();
            _btnMistOverride.Click += new EventHandler(btnToggleOverride_Click);
            _btnFloodOverride = new Button();
            _btnFloodOverride.Click += new EventHandler(btnToggleOverride_Click);
            _btnSpindleOverride = new Button();
            _btnSpindleOverride.Click += new EventHandler(btnToggleOverride_Click);
            cbSpindleCoarse = new CheckBox();
            _btnSpindleOverrideReset = new Button();
            _btnSpindleOverrideReset.Click += new EventHandler(btnFeedOverrideReset_Click);
            _btnRapidOverride25 = new Button();
            _btnRapidOverride25.Click += new EventHandler(btnRapidOverride_Click);
            _btnFeedOverrideReset = new Button();
            _btnFeedOverrideReset.Click += new EventHandler(btnFeedOverrideReset_Click);
            cbFeedCoarse = new CheckBox();
            Label44 = new Label();
            _btnSpindleMinus = new Button();
            _btnSpindleMinus.Click += new EventHandler(btnSpindleOverride_Click);
            _btnSpindlePlus = new Button();
            _btnSpindlePlus.Click += new EventHandler(btnSpindleOverride_Click);
            Label22 = new Label();
            _btnRapidOverride50 = new Button();
            _btnRapidOverride50.Click += new EventHandler(btnRapidOverride_Click);
            _btnRapidOverrideReset = new Button();
            _btnRapidOverrideReset.Click += new EventHandler(btnRapidOverride_Click);
            _btnRapidOverrideReset.Click += new EventHandler(btnFeedOverrideReset_Click);
            tbSpindleOvr = new TextBox();
            tbRapidOvr = new TextBox();
            tbFeedOvr = new TextBox();
            Label46 = new Label();
            _btnFeedMinus = new Button();
            _btnFeedMinus.Click += new EventHandler(btnFeedOverride_Click);
            _btnFeedPlus = new Button();
            _btnFeedPlus.Click += new EventHandler(btnFeedOverride_Click);
            gbState = new GroupBox();
            gbPinStatus = new GroupBox();
            cbFeedHold = new CheckBox();
            cbStartResume = new CheckBox();
            cbResetAbort = new CheckBox();
            _btnStatusClearPins = new Button();
            _btnStatusClearPins.Click += new EventHandler(btnStatusClearPins_Click);
            cbLimitX = new CheckBox();
            cbDoorOpen = new CheckBox();
            cbProbePin = new CheckBox();
            cbLimitZ = new CheckBox();
            cbLimitY = new CheckBox();
            Panel2 = new Panel();
            tbStateFeedRate = new TextBox();
            Label14 = new Label();
            tbStateTool = new TextBox();
            Label53 = new Label();
            Label50 = new Label();
            tbStateSpindleRPM = new TextBox();
            Panel1 = new Panel();
            _cbxStateFeedMode = new ComboBox();
            _cbxStateFeedMode.SelectionChangeCommitted += new EventHandler(cbxState_SelectionChangeCommittted);
            _cbxStateDistance = new ComboBox();
            _cbxStateDistance.SelectionChangeCommitted += new EventHandler(cbxState_SelectionChangeCommittted);
            Label16 = new Label();
            _cbxStateUnits = new ComboBox();
            _cbxStateUnits.SelectionChangeCommitted += new EventHandler(cbxState_SelectionChangeCommittted);
            Label123 = new Label();
            Lalbel49 = new Label();
            _cbxStatePlane = new ComboBox();
            _cbxStatePlane.SelectionChangeCommitted += new EventHandler(cbxState_SelectionChangeCommittted);
            Label47 = new Label();
            Label15 = new Label();
            _cbxStateOffset = new ComboBox();
            _cbxStateOffset.SelectionChangeCommitted += new EventHandler(cbxState_SelectionChangeCommittted);
            _cbxStateCoolant = new ComboBox();
            _cbxStateCoolant.SelectionChangeCommitted += new EventHandler(cbxState_SelectionChangeCommittted);
            Label45 = new Label();
            Label17 = new Label();
            _cbxStateSpindle = new ComboBox();
            _cbxStateSpindle.SelectionChangeCommitted += new EventHandler(cbxState_SelectionChangeCommittted);
            gbControl = new GroupBox();
            _btnCheckMode = new Button();
            _btnCheckMode.Click += new EventHandler(btnCheckMode_Click);
            _btnReset = new Button();
            _btnReset.Click += new EventHandler(btnReset_Click);
            _btnHold = new Button();
            _btnHold.Click += new EventHandler(btnHold_Click);
            _btnStartResume = new Button();
            _btnStartResume.Click += new EventHandler(btnStartResume_Click);
            _btnUnlock = new Button();
            _btnUnlock.Click += new EventHandler(btnUnlock_Click);
            gbMDI = new GroupBox();
            Label9 = new Label();
            _btnSend = new Button();
            _btnSend.Click += new EventHandler(btnSend_Click);
            _tbSendData = new TextBox();
            _tbSendData.KeyDown += new KeyEventHandler(tbSendData_KeyDown);
            gbJogging = new GroupBox();
            _btnZMinus = new RepeatButton.RepeatButton();
            _btnZMinus.Click += new EventHandler(btnJogArray_Click);
            _btnZPlus = new RepeatButton.RepeatButton();
            _btnZPlus.Click += new EventHandler(btnJogArray_Click);
            _btnXPlus = new RepeatButton.RepeatButton();
            _btnXPlus.Click += new EventHandler(btnJogArray_Click);
            _btnYMinus = new RepeatButton.RepeatButton();
            _btnYMinus.Click += new EventHandler(btnJogArray_Click);
            _btnXMinus = new RepeatButton.RepeatButton();
            _btnXMinus.Click += new EventHandler(btnJogArray_Click);
            _btnYPlus = new RepeatButton.RepeatButton();
            _btnYPlus.Click += new EventHandler(btnJogArray_Click);
            gbFeedRate = new GroupBox();
            _rbFeedRate1 = new RadioButton();
            _rbFeedRate1.CheckedChanged += new EventHandler(rbDistancex_CheckedChanged);
            _rbFeedRate2 = new RadioButton();
            _rbFeedRate2.CheckedChanged += new EventHandler(rbDistancex_CheckedChanged);
            _rbFeedRate3 = new RadioButton();
            _rbFeedRate3.CheckedChanged += new EventHandler(rbDistancex_CheckedChanged);
            _rbFeedRate4 = new RadioButton();
            _rbFeedRate4.CheckedChanged += new EventHandler(rbDistancex_CheckedChanged);
            gbDistance = new GroupBox();
            _rbDistance1 = new RadioButton();
            _rbDistance1.CheckedChanged += new EventHandler(rbDistancex_CheckedChanged);
            _rbDistance2 = new RadioButton();
            _rbDistance2.CheckedChanged += new EventHandler(rbDistancex_CheckedChanged);
            _rbDistance3 = new RadioButton();
            _rbDistance3.CheckedChanged += new EventHandler(rbDistancex_CheckedChanged);
            _rbDistance4 = new RadioButton();
            _rbDistance4.CheckedChanged += new EventHandler(rbDistancex_CheckedChanged);
            _cbUnits = new CheckBox();
            _cbUnits.CheckedChanged += new EventHandler(cbUnits_CheckedChanged);
            gbStatus = new GroupBox();
            Label25 = new Label();
            tbCurrentStatus = new TextBox();
            Label24 = new Label();
            prgbRxBuf = new ProgressBar();
            prgBarQ = new ProgressBar();
            lbResponses = new ListBox();
            gbGcode = new GroupBox();
            _btnFileStep = new Button();
            _btnFileStep.Click += new EventHandler(btnFileGroup_Click);
            cbMonitorEnable = new CheckBox();
            lblElapsedTime = new Label();
            Label23 = new Label();
            Label51 = new Label();
            lblCurrentLine = new Label();
            _dgvGcode = new DataGridView();
            _dgvGcode.CellValueNeeded += new DataGridViewCellValueEventHandler(dgvGcode_CellValueNeeded);
            stat = new DataGridViewTextBoxColumn();
            lineNum = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            _btnFileReload = new Button();
            _btnFileReload.Click += new EventHandler(btnFileGroup_Click);
            tbGCodeMessage = new TextBox();
            Label27 = new Label();
            lblTotalLines = new Label();
            _btnFilePause = new Button();
            _btnFilePause.Click += new EventHandler(btnFileGroup_Click);
            tbGcodeFile = new TextBox();
            _btnFileSelect = new Button();
            _btnFileSelect.Click += new EventHandler(btnFileGroup_Click);
            _btnFileSend = new Button();
            _btnFileSend.MouseHover += new EventHandler(btnFileSend_MouseHover);
            _btnFileSend.Click += new EventHandler(btnFileGroup_Click);
            _btnFileStop = new Button();
            _btnFileStop.Click += new EventHandler(btnFileGroup_Click);
            gbGrbl = new GroupBox();
            tcConnection = new TabControl();
            tbGrblCOM = new TabPage();
            _btnRescanPorts = new Button();
            _btnRescanPorts.Click += new EventHandler(btnRescanPorts_Click);
            _cbPorts = new ComboBox();
            _cbPorts.SelectedIndexChanged += new EventHandler(lbPorts_SelectedIndexChanged);
            _btnConnect = new Button();
            _btnConnect.Click += new EventHandler(btnConnDisconnect_Click);
            _cbBaud = new ComboBox();
            _cbBaud.SelectedIndexChanged += new EventHandler(cbBaud_SelectedIndexChanged);
            tbGrblIP = new TabPage();
            _btnIPConnect = new Button();
            _btnIPConnect.Click += new EventHandler(btnConnDisconnect_Click);
            tbIPAddress = new TextBox();
            gbPosition = new GroupBox();
            tabCtlPosition = new TabControl();
            tpWork = new TabPage();
            Panel5 = new Panel();
            _tbWorkZ = new TextBox();
            _tbWorkZ.Click += new EventHandler(tbWork_Click);
            tbMachZ = new TextBox();
            Panel4 = new Panel();
            _tbWorkY = new TextBox();
            _tbWorkY.Click += new EventHandler(tbWork_Click);
            tbMachY = new TextBox();
            Panel3 = new Panel();
            tbMachX = new TextBox();
            _tbWorkX = new TextBox();
            _tbWorkX.DoubleClick += new EventHandler(tbWorkX_TextChanged);
            _tbWorkX.Click += new EventHandler(tbWork_Click);
            GroupBox1 = new GroupBox();
            lblPositionCurrentOffset = new Label();
            _btnWorkSoftHome = new Button();
            _btnWorkSoftHome.Click += new EventHandler(btnPosition_Click);
            _btnHome = new Button();
            _btnHome.Click += new EventHandler(btnPosition_Click);
            _btnWorkSpclPosition = new Button();
            _btnWorkSpclPosition.Click += new EventHandler(btnPosition_Click);
            Label3 = new Label();
            _btnWork0 = new Button();
            _btnWork0.Click += new EventHandler(btnPosition_Click);
            Label2 = new Label();
            _btnWorkX0 = new Button();
            _btnWorkX0.Click += new EventHandler(btnWorkXYZ0_Click);
            Label1 = new Label();
            _btnWorkZ0 = new Button();
            _btnWorkZ0.Click += new EventHandler(btnWorkXYZ0_Click);
            _btnWorkY0 = new Button();
            _btnWorkY0.Click += new EventHandler(btnWorkXYZ0_Click);
            tpOffsets = new TabPage();
            _btnSetOffsetG59 = new Button();
            _btnSetOffsetG59.Click += new EventHandler(btnSetOffset_Click);
            _btnSetOffsetG58 = new Button();
            _btnSetOffsetG58.Click += new EventHandler(btnSetOffset_Click);
            _btnSetOffsetG57 = new Button();
            _btnSetOffsetG57.Click += new EventHandler(btnSetOffset_Click);
            _btnSetOffsetG56 = new Button();
            _btnSetOffsetG56.Click += new EventHandler(btnSetOffset_Click);
            _btnSetOffsetG55 = new Button();
            _btnSetOffsetG55.Click += new EventHandler(btnSetOffset_Click);
            _btnSetOffsetG54 = new Button();
            _btnSetOffsetG54.Click += new EventHandler(btnSetOffset_Click);
            Label10 = new Label();
            Label71 = new Label();
            tbOffSetsMachZ = new TextBox();
            Label19 = new Label();
            _tbOffsetsG56Y = new TextBox();
            _tbOffsetsG56Y.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            tbOffSetsMachY = new TextBox();
            _tbOffsetsG56X = new TextBox();
            _tbOffsetsG56X.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _tbOffsetsG56Z = new TextBox();
            _tbOffsetsG56Z.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            tbOffSetsMachX = new TextBox();
            _btnOffsetsG57Zero = new Button();
            _btnOffsetsG57Zero.Click += new EventHandler(btnOffsetsZero_Click);
            _tbOffsetsG54X = new TextBox();
            _tbOffsetsG54X.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _btnOffsetsG56Zero = new Button();
            _btnOffsetsG56Zero.Click += new EventHandler(btnOffsetsZero_Click);
            _tbOffsetsG54Y = new TextBox();
            _tbOffsetsG54Y.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _tbOffsetsG57Z = new TextBox();
            _tbOffsetsG57Z.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _btnOffsetsSave = new Button();
            _btnOffsetsSave.Click += new EventHandler(btnOffsetsSave_Click);
            _tbOffsetsG55X = new TextBox();
            _tbOffsetsG55X.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _tbOffsetsG54Z = new TextBox();
            _tbOffsetsG54Z.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _tbOffsetsG57Y = new TextBox();
            _tbOffsetsG57Y.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _btnOffsetsRetrieve = new Button();
            _btnOffsetsRetrieve.Click += new EventHandler(btnOffsetsRetrieve_Click);
            _tbOffsetsG55Y = new TextBox();
            _tbOffsetsG55Y.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _btnOffsetsG54Zero = new Button();
            _btnOffsetsG54Zero.Click += new EventHandler(btnOffsetsZero_Click);
            _tbOffsetsG57X = new TextBox();
            _tbOffsetsG57X.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _btnOffsetsLoad = new Button();
            _btnOffsetsLoad.Click += new EventHandler(btnOffsetsLoad_Click);
            _tbOffsetsG55Z = new TextBox();
            _tbOffsetsG55Z.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _tbOffsetsG59X = new TextBox();
            _tbOffsetsG59X.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _btnOffsetsG58Zero = new Button();
            _btnOffsetsG58Zero.Click += new EventHandler(btnOffsetsZero_Click);
            _btnOffsetsG43Zero = new Button();
            _btnOffsetsG43Zero.Click += new EventHandler(btnOffsetsZero_Click);
            _tbOffsetsG59Y = new TextBox();
            _tbOffsetsG59Y.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _tbOffsetsG43Z = new TextBox();
            _tbOffsetsG43Z.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _btnOffsetsG55Zero = new Button();
            _btnOffsetsG55Zero.Click += new EventHandler(btnOffsetsZero_Click);
            _tbOffsetsG59Z = new TextBox();
            _tbOffsetsG59Z.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            _tbOffsetsG58Z = new TextBox();
            _tbOffsetsG58Z.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            Label60 = new Label();
            _tbOffsetsG58Y = new TextBox();
            _tbOffsetsG58Y.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            Label20 = new Label();
            Label43 = new Label();
            _btnOffsetsG59Zero = new Button();
            _btnOffsetsG59Zero.Click += new EventHandler(btnOffsetsZero_Click);
            _tbOffsetsG58X = new TextBox();
            _tbOffsetsG58X.DoubleClick += new EventHandler(tbOffsets_DoubleClick);
            Label21 = new Label();
            tabPgSettings = new TabPage();
            gbMiscInfo = new GroupBox();
            Label49 = new Label();
            tbGrblOptions = new TextBox();
            Label48 = new Label();
            tbGrblVersion = new TextBox();
            gbGrblSettings = new GroupBox();
            Label4 = new Label();
            _dgGrblSettings = new DataGridView();
            _dgGrblSettings.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgGrblSettings_CellMouseDoubleClick);
            _btnSettingsGrbl = new Button();
            _btnSettingsGrbl.Click += new EventHandler(btnSettingsGrbl_Click);
            gbSettingsOffsets = new GroupBox();
            _btnOffsetsG28Set = new Button();
            _btnOffsetsG28Set.Click += new EventHandler(btnOffsetsZero_Click);
            _btnSettingsRetrieveLocations = new Button();
            _btnSettingsRetrieveLocations.Click += new EventHandler(btnOffsetsRetrieve_Click);
            Label7 = new Label();
            Label18 = new Label();
            tbOffsetsG30Y = new TextBox();
            tbOffsetsG30X = new TextBox();
            tbOffsetsG30Z = new TextBox();
            tbOffsetsG28X = new TextBox();
            _btnOffsetsG30Set = new Button();
            _btnOffsetsG30Set.Click += new EventHandler(btnOffsetsZero_Click);
            tbOffsetsG28Y = new TextBox();
            Label68 = new Label();
            tbOffsetsG28Z = new TextBox();
            Label69 = new Label();
            Label42 = new Label();
            gbSettingsMisc = new GroupBox();
            Label52 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            tbSettingsStartupDelay = new TextBox();
            _btnSettingsRefreshMisc = new Button();
            _btnSettingsRefreshMisc.Click += new EventHandler(btnSettingsRefreshMisc_Click);
            Label37 = new Label();
            Label36 = new Label();
            Label26 = new Label();
            gbSettingsPosition = new GroupBox();
            Label8 = new Label();
            _btnSettingsRefreshPosition = new Button();
            _btnSettingsRefreshPosition.Click += new EventHandler(btnSettingsRefreshMisc_Click);
            Label29 = new Label();
            Label28 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            gbSettingsJogging = new GroupBox();
            _btnSettingsRefreshJogging = new Button();
            _btnSettingsRefreshJogging.Click += new EventHandler(btnSettingsRefreshMisc_Click);
            Label41 = new Label();
            Label40 = new Label();
            Label39 = new Label();
            Label38 = new Label();
            Label35 = new Label();
            Label34 = new Label();
            Label32 = new Label();
            Label33 = new Label();
            Label31 = new Label();
            Label30 = new Label();
            TabPage1 = new TabPage();
            gbEditor = new GroupBox();
            _btnAdd = new Button();
            _btnAdd.Click += new EventHandler(btnAdd_Click);
            lblGCode = new Label();
            _tbGCode = new TextBox();
            _tbGCode.MouseHover += new EventHandler(UpdateToolTip);
            lblName = new Label();
            _tbName = new TextBox();
            _tbName.MouseHover += new EventHandler(UpdateToolTip);
            _btnCancel = new Button();
            _btnCancel.Click += new EventHandler(btnCancel_Click);
            _btnCancel.MouseHover += new EventHandler(UpdateToolTip);
            _btnOK = new Button();
            _btnOK.Click += new EventHandler(btnOK_Click);
            _btnOK.MouseHover += new EventHandler(UpdateToolTip);
            _dgMacros = new DataGridView();
            _dgMacros.CellValueChanged += new DataGridViewCellEventHandler(dgMacros_CellValueChanged);
            _dgMacros.DoubleClick += new EventHandler(dgMacros_DoubleClick);
            _dgMacros.MouseHover += new EventHandler(UpdateToolTip);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            lblStatusLabel = new Label();
            _btnDeleteMacro = new Button();
            _btnDeleteMacro.Click += new EventHandler(btnDeleteMacro_Click);
            _btnDeleteMacro.MouseHover += new EventHandler(UpdateToolTip);
            ofdGcodeFile = new OpenFileDialog();
            ToolTip1 = new ToolTip(components);
            sfdOffsets = new SaveFileDialog();
            ofdOffsets = new OpenFileDialog();
            GrblSettingsBindingSource = new BindingSource(components);
            cbVerbose = new CheckBox();
            tbSettingsGrblLastParam = new TextBox();
            tbTruncationDigits = new TextBox();
            tbSettingsDefaultExt = new TextBox();
            _cbSettingsLeftHanded = new CheckBox();
            _cbSettingsLeftHanded.CheckedChanged += new EventHandler(cbSettingsLeftHanded_CheckedChanged);
            cbSettingsConnectOnLoad = new CheckBox();
            cbSettingsPauseOnError = new CheckBox();
            cbStatusPollEnable = new CheckBox();
            tbSettingsRBuffSize = new TextBox();
            tbSettingsQSize = new TextBox();
            tbSettingsPollRate = new TextBox();
            tbSettingsSpclPosition2 = new TextBox();
            tbWorkZ0Cmd = new TextBox();
            tbWorkY0Cmd = new TextBox();
            tbWorkX0Cmd = new TextBox();
            tbSettingsZeroXYZCmd = new TextBox();
            tbSettingsSpclPosition1 = new TextBox();
            cbSettingsKeyboardJogging = new CheckBox();
            tbSettingsZRepeat = new TextBox();
            tbSettingsYRepeat = new TextBox();
            tbSettingsXRepeat = new TextBox();
            tbSettingsFRMetric = new TextBox();
            tbSettingsFIMetric = new TextBox();
            tbSettingsFRImperial = new TextBox();
            _cbSettingsMetric = new CheckBox();
            _cbSettingsMetric.CheckedChanged += new EventHandler(cbSettingsMetric_CheckedChanged);
            tbSettingsFIImperial = new TextBox();
            MenuStrip1.SuspendLayout();
            TabControl1.SuspendLayout();
            tabPgInterface.SuspendLayout();
            gbOverrides.SuspendLayout();
            gbState.SuspendLayout();
            gbPinStatus.SuspendLayout();
            Panel2.SuspendLayout();
            Panel1.SuspendLayout();
            gbControl.SuspendLayout();
            gbMDI.SuspendLayout();
            gbJogging.SuspendLayout();
            gbFeedRate.SuspendLayout();
            gbDistance.SuspendLayout();
            gbStatus.SuspendLayout();
            gbGcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvGcode).BeginInit();
            gbGrbl.SuspendLayout();
            tcConnection.SuspendLayout();
            tbGrblCOM.SuspendLayout();
            tbGrblIP.SuspendLayout();
            gbPosition.SuspendLayout();
            tabCtlPosition.SuspendLayout();
            tpWork.SuspendLayout();
            Panel5.SuspendLayout();
            Panel4.SuspendLayout();
            Panel3.SuspendLayout();
            GroupBox1.SuspendLayout();
            tpOffsets.SuspendLayout();
            tabPgSettings.SuspendLayout();
            gbMiscInfo.SuspendLayout();
            gbGrblSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgGrblSettings).BeginInit();
            gbSettingsOffsets.SuspendLayout();
            gbSettingsMisc.SuspendLayout();
            gbSettingsPosition.SuspendLayout();
            gbSettingsJogging.SuspendLayout();
            TabPage1.SuspendLayout();
            gbEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgMacros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrblSettingsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip1
            // 
            MenuStrip1.GripStyle = ToolStripGripStyle.Visible;
            MenuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem1, ToolsToolStripMenuItem, HelpToolStripMenuItem });
            resources.ApplyResources(MenuStrip1, "MenuStrip1");
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, _ExitToolStripMenuItem });
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            resources.ApplyResources(ToolStripMenuItem1, "ToolStripMenuItem1");
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            resources.ApplyResources(SaveToolStripMenuItem, "SaveToolStripMenuItem");
            // 
            // ExitToolStripMenuItem
            // 
            _ExitToolStripMenuItem.Name = "_ExitToolStripMenuItem";
            resources.ApplyResources(_ExitToolStripMenuItem, "ExitToolStripMenuItem");
            // 
            // ToolsToolStripMenuItem
            // 
            ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _OptionsToolStripMenuItem });
            ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            resources.ApplyResources(ToolsToolStripMenuItem, "ToolsToolStripMenuItem");
            // 
            // OptionsToolStripMenuItem
            // 
            _OptionsToolStripMenuItem.Name = "_OptionsToolStripMenuItem";
            resources.ApplyResources(_OptionsToolStripMenuItem, "OptionsToolStripMenuItem");
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _AboutToolStripMenuItem });
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            resources.ApplyResources(HelpToolStripMenuItem, "HelpToolStripMenuItem");
            // 
            // AboutToolStripMenuItem
            // 
            _AboutToolStripMenuItem.Name = "_AboutToolStripMenuItem";
            resources.ApplyResources(_AboutToolStripMenuItem, "AboutToolStripMenuItem");
            // 
            // TabControl1
            // 
            resources.ApplyResources(TabControl1, "TabControl1");
            TabControl1.Controls.Add(tabPgInterface);
            TabControl1.Controls.Add(tabPgSettings);
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.SizeMode = TabSizeMode.FillToRight;
            // 
            // tabPgInterface
            // 
            tabPgInterface.Controls.Add(gbOverrides);
            tabPgInterface.Controls.Add(gbState);
            tabPgInterface.Controls.Add(gbControl);
            tabPgInterface.Controls.Add(gbMDI);
            tabPgInterface.Controls.Add(gbJogging);
            tabPgInterface.Controls.Add(gbStatus);
            tabPgInterface.Controls.Add(gbGcode);
            tabPgInterface.Controls.Add(gbGrbl);
            tabPgInterface.Controls.Add(gbPosition);
            resources.ApplyResources(tabPgInterface, "tabPgInterface");
            tabPgInterface.Name = "tabPgInterface";
            tabPgInterface.UseVisualStyleBackColor = true;
            // 
            // gbOverrides
            // 
            gbOverrides.Controls.Add(_btnMistOverride);
            gbOverrides.Controls.Add(_btnFloodOverride);
            gbOverrides.Controls.Add(_btnSpindleOverride);
            gbOverrides.Controls.Add(cbSpindleCoarse);
            gbOverrides.Controls.Add(_btnSpindleOverrideReset);
            gbOverrides.Controls.Add(_btnRapidOverride25);
            gbOverrides.Controls.Add(_btnFeedOverrideReset);
            gbOverrides.Controls.Add(cbFeedCoarse);
            gbOverrides.Controls.Add(Label44);
            gbOverrides.Controls.Add(_btnSpindleMinus);
            gbOverrides.Controls.Add(_btnSpindlePlus);
            gbOverrides.Controls.Add(Label22);
            gbOverrides.Controls.Add(_btnRapidOverride50);
            gbOverrides.Controls.Add(_btnRapidOverrideReset);
            gbOverrides.Controls.Add(tbSpindleOvr);
            gbOverrides.Controls.Add(tbRapidOvr);
            gbOverrides.Controls.Add(tbFeedOvr);
            gbOverrides.Controls.Add(Label46);
            gbOverrides.Controls.Add(_btnFeedMinus);
            gbOverrides.Controls.Add(_btnFeedPlus);
            resources.ApplyResources(gbOverrides, "gbOverrides");
            gbOverrides.Name = "gbOverrides";
            gbOverrides.TabStop = false;
            // 
            // btnMistOverride
            // 
            resources.ApplyResources(_btnMistOverride, "btnMistOverride");
            _btnMistOverride.Name = "_btnMistOverride";
            _btnMistOverride.TabStop = false;
            _btnMistOverride.Tag = "MistOverride";
            _btnMistOverride.UseVisualStyleBackColor = true;
            // 
            // btnFloodOverride
            // 
            resources.ApplyResources(_btnFloodOverride, "btnFloodOverride");
            _btnFloodOverride.Name = "_btnFloodOverride";
            _btnFloodOverride.Tag = "FloodOverride";
            _btnFloodOverride.UseVisualStyleBackColor = true;
            // 
            // btnSpindleOverride
            // 
            resources.ApplyResources(_btnSpindleOverride, "btnSpindleOverride");
            _btnSpindleOverride.Name = "_btnSpindleOverride";
            _btnSpindleOverride.Tag = "SpindleOverride";
            _btnSpindleOverride.UseVisualStyleBackColor = true;
            // 
            // cbSpindleCoarse
            // 
            resources.ApplyResources(cbSpindleCoarse, "cbSpindleCoarse");
            cbSpindleCoarse.Checked = true;
            cbSpindleCoarse.CheckState = CheckState.Checked;
            cbSpindleCoarse.Name = "cbSpindleCoarse";
            cbSpindleCoarse.UseVisualStyleBackColor = true;
            // 
            // btnSpindleOverrideReset
            // 
            resources.ApplyResources(_btnSpindleOverrideReset, "btnSpindleOverrideReset");
            _btnSpindleOverrideReset.Name = "_btnSpindleOverrideReset";
            _btnSpindleOverrideReset.Tag = "Spindle";
            _btnSpindleOverrideReset.UseVisualStyleBackColor = true;
            // 
            // btnRapidOverride25
            // 
            resources.ApplyResources(_btnRapidOverride25, "btnRapidOverride25");
            _btnRapidOverride25.Name = "_btnRapidOverride25";
            _btnRapidOverride25.Tag = "25";
            _btnRapidOverride25.UseVisualStyleBackColor = true;
            // 
            // btnFeedOverrideReset
            // 
            resources.ApplyResources(_btnFeedOverrideReset, "btnFeedOverrideReset");
            _btnFeedOverrideReset.Name = "_btnFeedOverrideReset";
            _btnFeedOverrideReset.Tag = "Feed";
            _btnFeedOverrideReset.UseVisualStyleBackColor = true;
            // 
            // cbFeedCoarse
            // 
            resources.ApplyResources(cbFeedCoarse, "cbFeedCoarse");
            cbFeedCoarse.Checked = true;
            cbFeedCoarse.CheckState = CheckState.Checked;
            cbFeedCoarse.Name = "cbFeedCoarse";
            cbFeedCoarse.UseVisualStyleBackColor = true;
            // 
            // Label44
            // 
            resources.ApplyResources(Label44, "Label44");
            Label44.Name = "Label44";
            // 
            // btnSpindleMinus
            // 
            resources.ApplyResources(_btnSpindleMinus, "btnSpindleMinus");
            _btnSpindleMinus.Name = "_btnSpindleMinus";
            _btnSpindleMinus.Tag = "minus";
            _btnSpindleMinus.UseVisualStyleBackColor = true;
            // 
            // btnSpindlePlus
            // 
            resources.ApplyResources(_btnSpindlePlus, "btnSpindlePlus");
            _btnSpindlePlus.Name = "_btnSpindlePlus";
            _btnSpindlePlus.Tag = "plus";
            _btnSpindlePlus.UseVisualStyleBackColor = true;
            // 
            // Label22
            // 
            resources.ApplyResources(Label22, "Label22");
            Label22.Name = "Label22";
            // 
            // btnRapidOverride50
            // 
            resources.ApplyResources(_btnRapidOverride50, "btnRapidOverride50");
            _btnRapidOverride50.Name = "_btnRapidOverride50";
            _btnRapidOverride50.Tag = "50";
            _btnRapidOverride50.UseVisualStyleBackColor = true;
            // 
            // btnRapidOverrideReset
            // 
            resources.ApplyResources(_btnRapidOverrideReset, "btnRapidOverrideReset");
            _btnRapidOverrideReset.Name = "_btnRapidOverrideReset";
            _btnRapidOverrideReset.Tag = "Rapid";
            _btnRapidOverrideReset.UseVisualStyleBackColor = true;
            // 
            // tbSpindleOvr
            // 
            resources.ApplyResources(tbSpindleOvr, "tbSpindleOvr");
            tbSpindleOvr.Name = "tbSpindleOvr";
            // 
            // tbRapidOvr
            // 
            resources.ApplyResources(tbRapidOvr, "tbRapidOvr");
            tbRapidOvr.Name = "tbRapidOvr";
            // 
            // tbFeedOvr
            // 
            resources.ApplyResources(tbFeedOvr, "tbFeedOvr");
            tbFeedOvr.Name = "tbFeedOvr";
            // 
            // Label46
            // 
            resources.ApplyResources(Label46, "Label46");
            Label46.Name = "Label46";
            // 
            // btnFeedMinus
            // 
            resources.ApplyResources(_btnFeedMinus, "btnFeedMinus");
            _btnFeedMinus.Name = "_btnFeedMinus";
            _btnFeedMinus.Tag = "minus";
            _btnFeedMinus.UseVisualStyleBackColor = true;
            // 
            // btnFeedPlus
            // 
            resources.ApplyResources(_btnFeedPlus, "btnFeedPlus");
            _btnFeedPlus.Name = "_btnFeedPlus";
            _btnFeedPlus.Tag = "plus";
            _btnFeedPlus.UseVisualStyleBackColor = true;
            // 
            // gbState
            // 
            gbState.Controls.Add(gbPinStatus);
            gbState.Controls.Add(Panel2);
            gbState.Controls.Add(Panel1);
            resources.ApplyResources(gbState, "gbState");
            gbState.Name = "gbState";
            gbState.TabStop = false;
            // 
            // gbPinStatus
            // 
            gbPinStatus.Controls.Add(cbFeedHold);
            gbPinStatus.Controls.Add(cbStartResume);
            gbPinStatus.Controls.Add(cbResetAbort);
            gbPinStatus.Controls.Add(_btnStatusClearPins);
            gbPinStatus.Controls.Add(cbLimitX);
            gbPinStatus.Controls.Add(cbDoorOpen);
            gbPinStatus.Controls.Add(cbProbePin);
            gbPinStatus.Controls.Add(cbLimitZ);
            gbPinStatus.Controls.Add(cbLimitY);
            resources.ApplyResources(gbPinStatus, "gbPinStatus");
            gbPinStatus.Name = "gbPinStatus";
            gbPinStatus.TabStop = false;
            // 
            // cbFeedHold
            // 
            cbFeedHold.AutoCheck = false;
            resources.ApplyResources(cbFeedHold, "cbFeedHold");
            cbFeedHold.Name = "cbFeedHold";
            ToolTip1.SetToolTip(cbFeedHold, resources.GetString("cbFeedHold.ToolTip"));
            cbFeedHold.UseVisualStyleBackColor = true;
            // 
            // cbStartResume
            // 
            cbStartResume.AutoCheck = false;
            resources.ApplyResources(cbStartResume, "cbStartResume");
            cbStartResume.Name = "cbStartResume";
            ToolTip1.SetToolTip(cbStartResume, resources.GetString("cbStartResume.ToolTip"));
            cbStartResume.UseVisualStyleBackColor = true;
            // 
            // cbResetAbort
            // 
            cbResetAbort.AutoCheck = false;
            resources.ApplyResources(cbResetAbort, "cbResetAbort");
            cbResetAbort.Name = "cbResetAbort";
            ToolTip1.SetToolTip(cbResetAbort, resources.GetString("cbResetAbort.ToolTip"));
            cbResetAbort.UseVisualStyleBackColor = true;
            // 
            // btnStatusClearPins
            // 
            resources.ApplyResources(_btnStatusClearPins, "btnStatusClearPins");
            _btnStatusClearPins.Name = "_btnStatusClearPins";
            _btnStatusClearPins.UseVisualStyleBackColor = true;
            // 
            // cbLimitX
            // 
            cbLimitX.AutoCheck = false;
            resources.ApplyResources(cbLimitX, "cbLimitX");
            cbLimitX.Name = "cbLimitX";
            ToolTip1.SetToolTip(cbLimitX, resources.GetString("cbLimitX.ToolTip"));
            cbLimitX.UseVisualStyleBackColor = true;
            // 
            // cbDoorOpen
            // 
            cbDoorOpen.AutoCheck = false;
            resources.ApplyResources(cbDoorOpen, "cbDoorOpen");
            cbDoorOpen.Name = "cbDoorOpen";
            ToolTip1.SetToolTip(cbDoorOpen, resources.GetString("cbDoorOpen.ToolTip"));
            cbDoorOpen.UseVisualStyleBackColor = true;
            // 
            // cbProbePin
            // 
            cbProbePin.AutoCheck = false;
            resources.ApplyResources(cbProbePin, "cbProbePin");
            cbProbePin.Name = "cbProbePin";
            ToolTip1.SetToolTip(cbProbePin, resources.GetString("cbProbePin.ToolTip"));
            cbProbePin.UseVisualStyleBackColor = true;
            // 
            // cbLimitZ
            // 
            cbLimitZ.AutoCheck = false;
            resources.ApplyResources(cbLimitZ, "cbLimitZ");
            cbLimitZ.Name = "cbLimitZ";
            ToolTip1.SetToolTip(cbLimitZ, resources.GetString("cbLimitZ.ToolTip"));
            cbLimitZ.UseVisualStyleBackColor = true;
            // 
            // cbLimitY
            // 
            cbLimitY.AutoCheck = false;
            resources.ApplyResources(cbLimitY, "cbLimitY");
            cbLimitY.Name = "cbLimitY";
            ToolTip1.SetToolTip(cbLimitY, resources.GetString("cbLimitY.ToolTip"));
            cbLimitY.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(tbStateFeedRate);
            Panel2.Controls.Add(Label14);
            Panel2.Controls.Add(tbStateTool);
            Panel2.Controls.Add(Label53);
            Panel2.Controls.Add(Label50);
            Panel2.Controls.Add(tbStateSpindleRPM);
            resources.ApplyResources(Panel2, "Panel2");
            Panel2.Name = "Panel2";
            // 
            // tbStateFeedRate
            // 
            resources.ApplyResources(tbStateFeedRate, "tbStateFeedRate");
            tbStateFeedRate.Name = "tbStateFeedRate";
            // 
            // Label14
            // 
            resources.ApplyResources(Label14, "Label14");
            Label14.Name = "Label14";
            // 
            // tbStateTool
            // 
            resources.ApplyResources(tbStateTool, "tbStateTool");
            tbStateTool.Name = "tbStateTool";
            // 
            // Label53
            // 
            resources.ApplyResources(Label53, "Label53");
            Label53.Name = "Label53";
            // 
            // Label50
            // 
            resources.ApplyResources(Label50, "Label50");
            Label50.Name = "Label50";
            // 
            // tbStateSpindleRPM
            // 
            resources.ApplyResources(tbStateSpindleRPM, "tbStateSpindleRPM");
            tbStateSpindleRPM.Name = "tbStateSpindleRPM";
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(_cbxStateFeedMode);
            Panel1.Controls.Add(_cbxStateDistance);
            Panel1.Controls.Add(Label16);
            Panel1.Controls.Add(_cbxStateUnits);
            Panel1.Controls.Add(Label123);
            Panel1.Controls.Add(Lalbel49);
            Panel1.Controls.Add(_cbxStatePlane);
            Panel1.Controls.Add(Label47);
            Panel1.Controls.Add(Label15);
            Panel1.Controls.Add(_cbxStateOffset);
            Panel1.Controls.Add(_cbxStateCoolant);
            Panel1.Controls.Add(Label45);
            Panel1.Controls.Add(Label17);
            Panel1.Controls.Add(_cbxStateSpindle);
            resources.ApplyResources(Panel1, "Panel1");
            Panel1.Name = "Panel1";
            // 
            // cbxStateFeedMode
            // 
            _cbxStateFeedMode.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbxStateFeedMode.FormattingEnabled = true;
            _cbxStateFeedMode.Items.AddRange(new object[] { resources.GetString("cbxStateFeedMode.Items"), resources.GetString("cbxStateFeedMode.Items1"), resources.GetString("cbxStateFeedMode.Items2") });
            resources.ApplyResources(_cbxStateFeedMode, "cbxStateFeedMode");
            _cbxStateFeedMode.Name = "_cbxStateFeedMode";
            // 
            // cbxStateDistance
            // 
            _cbxStateDistance.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbxStateDistance.FormattingEnabled = true;
            _cbxStateDistance.Items.AddRange(new object[] { resources.GetString("cbxStateDistance.Items"), resources.GetString("cbxStateDistance.Items1"), resources.GetString("cbxStateDistance.Items2") });
            resources.ApplyResources(_cbxStateDistance, "cbxStateDistance");
            _cbxStateDistance.Name = "_cbxStateDistance";
            // 
            // Label16
            // 
            resources.ApplyResources(Label16, "Label16");
            Label16.Name = "Label16";
            // 
            // cbxStateUnits
            // 
            _cbxStateUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbxStateUnits.FormattingEnabled = true;
            _cbxStateUnits.Items.AddRange(new object[] { resources.GetString("cbxStateUnits.Items"), resources.GetString("cbxStateUnits.Items1"), resources.GetString("cbxStateUnits.Items2") });
            resources.ApplyResources(_cbxStateUnits, "cbxStateUnits");
            _cbxStateUnits.Name = "_cbxStateUnits";
            // 
            // Label123
            // 
            resources.ApplyResources(Label123, "Label123");
            Label123.Name = "Label123";
            // 
            // Lalbel49
            // 
            resources.ApplyResources(Lalbel49, "Lalbel49");
            Lalbel49.Name = "Lalbel49";
            // 
            // cbxStatePlane
            // 
            _cbxStatePlane.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbxStatePlane.FormattingEnabled = true;
            _cbxStatePlane.Items.AddRange(new object[] { resources.GetString("cbxStatePlane.Items"), resources.GetString("cbxStatePlane.Items1"), resources.GetString("cbxStatePlane.Items2"), resources.GetString("cbxStatePlane.Items3") });
            resources.ApplyResources(_cbxStatePlane, "cbxStatePlane");
            _cbxStatePlane.Name = "_cbxStatePlane";
            // 
            // Label47
            // 
            resources.ApplyResources(Label47, "Label47");
            Label47.Name = "Label47";
            // 
            // Label15
            // 
            resources.ApplyResources(Label15, "Label15");
            Label15.Name = "Label15";
            // 
            // cbxStateOffset
            // 
            _cbxStateOffset.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbxStateOffset.FormattingEnabled = true;
            _cbxStateOffset.Items.AddRange(new object[] { resources.GetString("cbxStateOffset.Items"), resources.GetString("cbxStateOffset.Items1"), resources.GetString("cbxStateOffset.Items2"), resources.GetString("cbxStateOffset.Items3"), resources.GetString("cbxStateOffset.Items4"), resources.GetString("cbxStateOffset.Items5"), resources.GetString("cbxStateOffset.Items6") });
            resources.ApplyResources(_cbxStateOffset, "cbxStateOffset");
            _cbxStateOffset.Name = "_cbxStateOffset";
            // 
            // cbxStateCoolant
            // 
            _cbxStateCoolant.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbxStateCoolant.FormattingEnabled = true;
            _cbxStateCoolant.Items.AddRange(new object[] { resources.GetString("cbxStateCoolant.Items"), resources.GetString("cbxStateCoolant.Items1"), resources.GetString("cbxStateCoolant.Items2") });
            resources.ApplyResources(_cbxStateCoolant, "cbxStateCoolant");
            _cbxStateCoolant.Name = "_cbxStateCoolant";
            // 
            // Label45
            // 
            resources.ApplyResources(Label45, "Label45");
            Label45.Name = "Label45";
            // 
            // Label17
            // 
            resources.ApplyResources(Label17, "Label17");
            Label17.Name = "Label17";
            // 
            // cbxStateSpindle
            // 
            _cbxStateSpindle.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbxStateSpindle.FormattingEnabled = true;
            _cbxStateSpindle.Items.AddRange(new object[] { resources.GetString("cbxStateSpindle.Items"), resources.GetString("cbxStateSpindle.Items1"), resources.GetString("cbxStateSpindle.Items2"), resources.GetString("cbxStateSpindle.Items3") });
            resources.ApplyResources(_cbxStateSpindle, "cbxStateSpindle");
            _cbxStateSpindle.Name = "_cbxStateSpindle";
            // 
            // gbControl
            // 
            gbControl.Controls.Add(_btnCheckMode);
            gbControl.Controls.Add(_btnReset);
            gbControl.Controls.Add(_btnHold);
            gbControl.Controls.Add(_btnStartResume);
            gbControl.Controls.Add(_btnUnlock);
            resources.ApplyResources(gbControl, "gbControl");
            gbControl.Name = "gbControl";
            gbControl.TabStop = false;
            // 
            // btnCheckMode
            // 
            resources.ApplyResources(_btnCheckMode, "btnCheckMode");
            _btnCheckMode.Name = "_btnCheckMode";
            _btnCheckMode.UseCompatibleTextRendering = true;
            _btnCheckMode.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            resources.ApplyResources(_btnReset, "btnReset");
            _btnReset.BackColor = Color.Transparent;
            _btnReset.Name = "_btnReset";
            _btnReset.UseCompatibleTextRendering = true;
            _btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHold
            // 
            resources.ApplyResources(_btnHold, "btnHold");
            _btnHold.BackColor = Color.Transparent;
            _btnHold.Name = "_btnHold";
            _btnHold.UseCompatibleTextRendering = true;
            _btnHold.UseVisualStyleBackColor = false;
            // 
            // btnStartResume
            // 
            resources.ApplyResources(_btnStartResume, "btnStartResume");
            _btnStartResume.Name = "_btnStartResume";
            _btnStartResume.UseCompatibleTextRendering = true;
            _btnStartResume.UseVisualStyleBackColor = true;
            // 
            // btnUnlock
            // 
            resources.ApplyResources(_btnUnlock, "btnUnlock");
            _btnUnlock.BackColor = Color.Transparent;
            _btnUnlock.Name = "_btnUnlock";
            _btnUnlock.UseCompatibleTextRendering = true;
            _btnUnlock.UseVisualStyleBackColor = false;
            // 
            // gbMDI
            // 
            gbMDI.Controls.Add(Label9);
            gbMDI.Controls.Add(_btnSend);
            gbMDI.Controls.Add(_tbSendData);
            resources.ApplyResources(gbMDI, "gbMDI");
            gbMDI.Name = "gbMDI";
            gbMDI.TabStop = false;
            // 
            // Label9
            // 
            resources.ApplyResources(Label9, "Label9");
            Label9.Name = "Label9";
            // 
            // btnSend
            // 
            resources.ApplyResources(_btnSend, "btnSend");
            _btnSend.Name = "_btnSend";
            _btnSend.UseVisualStyleBackColor = true;
            // 
            // tbSendData
            // 
            _tbSendData.CharacterCasing = CharacterCasing.Upper;
            resources.ApplyResources(_tbSendData, "tbSendData");
            _tbSendData.Name = "_tbSendData";
            // 
            // gbJogging
            // 
            resources.ApplyResources(gbJogging, "gbJogging");
            gbJogging.Controls.Add(_btnZMinus);
            gbJogging.Controls.Add(_btnZPlus);
            gbJogging.Controls.Add(_btnXPlus);
            gbJogging.Controls.Add(_btnYMinus);
            gbJogging.Controls.Add(_btnXMinus);
            gbJogging.Controls.Add(_btnYPlus);
            gbJogging.Controls.Add(gbFeedRate);
            gbJogging.Controls.Add(gbDistance);
            gbJogging.Controls.Add(_cbUnits);
            gbJogging.Name = "gbJogging";
            gbJogging.TabStop = false;
            // 
            // btnZMinus
            // 
            resources.ApplyResources(_btnZMinus, "btnZMinus");
            _btnZMinus.Interval = 100;
            _btnZMinus.Name = "_btnZMinus";
            _btnZMinus.Tag = "Z-";
            _btnZMinus.UseVisualStyleBackColor = true;
            // 
            // btnZPlus
            // 
            resources.ApplyResources(_btnZPlus, "btnZPlus");
            _btnZPlus.Interval = 100;
            _btnZPlus.Name = "_btnZPlus";
            _btnZPlus.Tag = "Z+";
            _btnZPlus.UseVisualStyleBackColor = true;
            // 
            // btnXPlus
            // 
            resources.ApplyResources(_btnXPlus, "btnXPlus");
            _btnXPlus.Interval = 100;
            _btnXPlus.Name = "_btnXPlus";
            _btnXPlus.Tag = "X+";
            _btnXPlus.UseVisualStyleBackColor = true;
            // 
            // btnYMinus
            // 
            resources.ApplyResources(_btnYMinus, "btnYMinus");
            _btnYMinus.Interval = 100;
            _btnYMinus.Name = "_btnYMinus";
            _btnYMinus.Tag = "Y-";
            _btnYMinus.UseVisualStyleBackColor = true;
            // 
            // btnXMinus
            // 
            resources.ApplyResources(_btnXMinus, "btnXMinus");
            _btnXMinus.Interval = 100;
            _btnXMinus.Name = "_btnXMinus";
            _btnXMinus.Tag = "X-";
            _btnXMinus.UseVisualStyleBackColor = true;
            // 
            // btnYPlus
            // 
            resources.ApplyResources(_btnYPlus, "btnYPlus");
            _btnYPlus.Interval = 100;
            _btnYPlus.Name = "_btnYPlus";
            _btnYPlus.Tag = "Y+";
            _btnYPlus.UseVisualStyleBackColor = true;
            // 
            // gbFeedRate
            // 
            gbFeedRate.Controls.Add(_rbFeedRate1);
            gbFeedRate.Controls.Add(_rbFeedRate2);
            gbFeedRate.Controls.Add(_rbFeedRate3);
            gbFeedRate.Controls.Add(_rbFeedRate4);
            resources.ApplyResources(gbFeedRate, "gbFeedRate");
            gbFeedRate.Name = "gbFeedRate";
            gbFeedRate.TabStop = false;
            // 
            // rbFeedRate1
            // 
            resources.ApplyResources(_rbFeedRate1, "rbFeedRate1");
            _rbFeedRate1.Cursor = Cursors.Default;
            _rbFeedRate1.Name = "_rbFeedRate1";
            _rbFeedRate1.TabStop = true;
            _rbFeedRate1.Tag = "F1";
            _rbFeedRate1.UseVisualStyleBackColor = true;
            // 
            // rbFeedRate2
            // 
            resources.ApplyResources(_rbFeedRate2, "rbFeedRate2");
            _rbFeedRate2.Name = "_rbFeedRate2";
            _rbFeedRate2.TabStop = true;
            _rbFeedRate2.Tag = "F2";
            _rbFeedRate2.UseVisualStyleBackColor = true;
            // 
            // rbFeedRate3
            // 
            resources.ApplyResources(_rbFeedRate3, "rbFeedRate3");
            _rbFeedRate3.Name = "_rbFeedRate3";
            _rbFeedRate3.TabStop = true;
            _rbFeedRate3.Tag = "F3";
            _rbFeedRate3.UseVisualStyleBackColor = true;
            // 
            // rbFeedRate4
            // 
            resources.ApplyResources(_rbFeedRate4, "rbFeedRate4");
            _rbFeedRate4.Name = "_rbFeedRate4";
            _rbFeedRate4.TabStop = true;
            _rbFeedRate4.Tag = "F4";
            _rbFeedRate4.UseVisualStyleBackColor = true;
            // 
            // gbDistance
            // 
            gbDistance.Controls.Add(_rbDistance1);
            gbDistance.Controls.Add(_rbDistance2);
            gbDistance.Controls.Add(_rbDistance3);
            gbDistance.Controls.Add(_rbDistance4);
            resources.ApplyResources(gbDistance, "gbDistance");
            gbDistance.Name = "gbDistance";
            gbDistance.TabStop = false;
            // 
            // rbDistance1
            // 
            resources.ApplyResources(_rbDistance1, "rbDistance1");
            _rbDistance1.Name = "_rbDistance1";
            _rbDistance1.TabStop = true;
            _rbDistance1.Tag = "I1";
            _rbDistance1.UseVisualStyleBackColor = true;
            // 
            // rbDistance2
            // 
            resources.ApplyResources(_rbDistance2, "rbDistance2");
            _rbDistance2.Name = "_rbDistance2";
            _rbDistance2.TabStop = true;
            _rbDistance2.Tag = "I2";
            _rbDistance2.UseVisualStyleBackColor = true;
            // 
            // rbDistance3
            // 
            resources.ApplyResources(_rbDistance3, "rbDistance3");
            _rbDistance3.Name = "_rbDistance3";
            _rbDistance3.TabStop = true;
            _rbDistance3.Tag = "I3";
            _rbDistance3.UseVisualStyleBackColor = true;
            // 
            // rbDistance4
            // 
            resources.ApplyResources(_rbDistance4, "rbDistance4");
            _rbDistance4.Name = "_rbDistance4";
            _rbDistance4.TabStop = true;
            _rbDistance4.Tag = "I4";
            _rbDistance4.UseVisualStyleBackColor = true;
            // 
            // cbUnits
            // 
            resources.ApplyResources(_cbUnits, "cbUnits");
            _cbUnits.Name = "_cbUnits";
            _cbUnits.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            resources.ApplyResources(gbStatus, "gbStatus");
            gbStatus.Controls.Add(Label25);
            gbStatus.Controls.Add(tbCurrentStatus);
            gbStatus.Controls.Add(Label24);
            gbStatus.Controls.Add(prgbRxBuf);
            gbStatus.Controls.Add(prgBarQ);
            gbStatus.Controls.Add(cbVerbose);
            gbStatus.Controls.Add(lbResponses);
            gbStatus.Name = "gbStatus";
            gbStatus.TabStop = false;
            // 
            // Label25
            // 
            resources.ApplyResources(Label25, "Label25");
            Label25.Name = "Label25";
            // 
            // tbCurrentStatus
            // 
            resources.ApplyResources(tbCurrentStatus, "tbCurrentStatus");
            tbCurrentStatus.Name = "tbCurrentStatus";
            ToolTip1.SetToolTip(tbCurrentStatus, resources.GetString("tbCurrentStatus.ToolTip"));
            // 
            // Label24
            // 
            resources.ApplyResources(Label24, "Label24");
            Label24.Name = "Label24";
            // 
            // prgbRxBuf
            // 
            resources.ApplyResources(prgbRxBuf, "prgbRxBuf");
            prgbRxBuf.Maximum = 127;
            prgbRxBuf.Name = "prgbRxBuf";
            prgbRxBuf.Style = ProgressBarStyle.Continuous;
            // 
            // prgBarQ
            // 
            resources.ApplyResources(prgBarQ, "prgBarQ");
            prgBarQ.Maximum = 25;
            prgBarQ.Name = "prgBarQ";
            prgBarQ.Style = ProgressBarStyle.Continuous;
            // 
            // lbResponses
            // 
            resources.ApplyResources(lbResponses, "lbResponses");
            lbResponses.FormattingEnabled = true;
            lbResponses.Name = "lbResponses";
            // 
            // gbGcode
            // 
            resources.ApplyResources(gbGcode, "gbGcode");
            gbGcode.Controls.Add(_btnFileStep);
            gbGcode.Controls.Add(cbMonitorEnable);
            gbGcode.Controls.Add(lblElapsedTime);
            gbGcode.Controls.Add(Label23);
            gbGcode.Controls.Add(Label51);
            gbGcode.Controls.Add(lblCurrentLine);
            gbGcode.Controls.Add(_dgvGcode);
            gbGcode.Controls.Add(_btnFileReload);
            gbGcode.Controls.Add(tbGCodeMessage);
            gbGcode.Controls.Add(Label27);
            gbGcode.Controls.Add(lblTotalLines);
            gbGcode.Controls.Add(_btnFilePause);
            gbGcode.Controls.Add(tbGcodeFile);
            gbGcode.Controls.Add(_btnFileSelect);
            gbGcode.Controls.Add(_btnFileSend);
            gbGcode.Controls.Add(_btnFileStop);
            gbGcode.Name = "gbGcode";
            gbGcode.TabStop = false;
            // 
            // btnFileStep
            // 
            resources.ApplyResources(_btnFileStep, "btnFileStep");
            _btnFileStep.Name = "_btnFileStep";
            _btnFileStep.Tag = "Step";
            ToolTip1.SetToolTip(_btnFileStep, resources.GetString("btnFileStep.ToolTip"));
            _btnFileStep.UseVisualStyleBackColor = true;
            // 
            // cbMonitorEnable
            // 
            resources.ApplyResources(cbMonitorEnable, "cbMonitorEnable");
            cbMonitorEnable.Checked = true;
            cbMonitorEnable.CheckState = CheckState.Checked;
            cbMonitorEnable.Name = "cbMonitorEnable";
            cbMonitorEnable.UseVisualStyleBackColor = true;
            // 
            // lblElapsedTime
            // 
            resources.ApplyResources(lblElapsedTime, "lblElapsedTime");
            lblElapsedTime.Name = "lblElapsedTime";
            // 
            // Label23
            // 
            resources.ApplyResources(Label23, "Label23");
            Label23.Name = "Label23";
            // 
            // Label51
            // 
            resources.ApplyResources(Label51, "Label51");
            Label51.Name = "Label51";
            // 
            // lblCurrentLine
            // 
            resources.ApplyResources(lblCurrentLine, "lblCurrentLine");
            lblCurrentLine.Name = "lblCurrentLine";
            // 
            // dgvGcode
            // 
            _dgvGcode.AccessibleRole = AccessibleRole.None;
            _dgvGcode.AllowUserToAddRows = false;
            _dgvGcode.AllowUserToDeleteRows = false;
            _dgvGcode.AllowUserToResizeRows = false;
            resources.ApplyResources(_dgvGcode, "dgvGcode");
            _dgvGcode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgvGcode.Columns.AddRange(new DataGridViewColumn[] { stat, lineNum, data });
            _dgvGcode.MultiSelect = false;
            _dgvGcode.Name = "_dgvGcode";
            _dgvGcode.ReadOnly = true;
            _dgvGcode.RowHeadersVisible = false;
            _dgvGcode.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvGcode.StandardTab = true;
            _dgvGcode.VirtualMode = true;
            // 
            // stat
            // 
            stat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            stat.Frozen = true;
            resources.ApplyResources(stat, "stat");
            stat.Name = "stat";
            stat.ReadOnly = true;
            stat.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lineNum
            // 
            lineNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(lineNum, "lineNum");
            lineNum.Name = "lineNum";
            lineNum.ReadOnly = true;
            lineNum.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // data
            // 
            data.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(data, "data");
            data.Name = "data";
            data.ReadOnly = true;
            data.Resizable = DataGridViewTriState.False;
            data.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnFileReload
            // 
            resources.ApplyResources(_btnFileReload, "btnFileReload");
            _btnFileReload.Name = "_btnFileReload";
            _btnFileReload.Tag = "Reload";
            ToolTip1.SetToolTip(_btnFileReload, resources.GetString("btnFileReload.ToolTip"));
            _btnFileReload.UseVisualStyleBackColor = true;
            // 
            // tbGCodeMessage
            // 
            tbGCodeMessage.BorderStyle = BorderStyle.None;
            resources.ApplyResources(tbGCodeMessage, "tbGCodeMessage");
            tbGCodeMessage.Name = "tbGCodeMessage";
            // 
            // Label27
            // 
            resources.ApplyResources(Label27, "Label27");
            Label27.Name = "Label27";
            // 
            // lblTotalLines
            // 
            resources.ApplyResources(lblTotalLines, "lblTotalLines");
            lblTotalLines.Name = "lblTotalLines";
            // 
            // btnFilePause
            // 
            resources.ApplyResources(_btnFilePause, "btnFilePause");
            _btnFilePause.Name = "_btnFilePause";
            _btnFilePause.Tag = "Pause";
            ToolTip1.SetToolTip(_btnFilePause, resources.GetString("btnFilePause.ToolTip"));
            _btnFilePause.UseVisualStyleBackColor = true;
            // 
            // tbGcodeFile
            // 
            resources.ApplyResources(tbGcodeFile, "tbGcodeFile");
            tbGcodeFile.Name = "tbGcodeFile";
            // 
            // btnFileSelect
            // 
            resources.ApplyResources(_btnFileSelect, "btnFileSelect");
            _btnFileSelect.Name = "_btnFileSelect";
            _btnFileSelect.Tag = "File";
            ToolTip1.SetToolTip(_btnFileSelect, resources.GetString("btnFileSelect.ToolTip"));
            _btnFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnFileSend
            // 
            resources.ApplyResources(_btnFileSend, "btnFileSend");
            _btnFileSend.Name = "_btnFileSend";
            _btnFileSend.Tag = "Send";
            ToolTip1.SetToolTip(_btnFileSend, resources.GetString("btnFileSend.ToolTip"));
            _btnFileSend.UseVisualStyleBackColor = true;
            // 
            // btnFileStop
            // 
            resources.ApplyResources(_btnFileStop, "btnFileStop");
            _btnFileStop.Name = "_btnFileStop";
            _btnFileStop.Tag = "Stop";
            ToolTip1.SetToolTip(_btnFileStop, resources.GetString("btnFileStop.ToolTip"));
            _btnFileStop.UseVisualStyleBackColor = true;
            // 
            // gbGrbl
            // 
            resources.ApplyResources(gbGrbl, "gbGrbl");
            gbGrbl.Controls.Add(tcConnection);
            gbGrbl.Name = "gbGrbl";
            gbGrbl.TabStop = false;
            // 
            // tcConnection
            // 
            tcConnection.Controls.Add(tbGrblCOM);
            tcConnection.Controls.Add(tbGrblIP);
            resources.ApplyResources(tcConnection, "tcConnection");
            tcConnection.Name = "tcConnection";
            tcConnection.SelectedIndex = 0;
            // 
            // tbGrblCOM
            // 
            tbGrblCOM.Controls.Add(_btnRescanPorts);
            tbGrblCOM.Controls.Add(_cbPorts);
            tbGrblCOM.Controls.Add(_btnConnect);
            tbGrblCOM.Controls.Add(_cbBaud);
            resources.ApplyResources(tbGrblCOM, "tbGrblCOM");
            tbGrblCOM.Name = "tbGrblCOM";
            tbGrblCOM.UseVisualStyleBackColor = true;
            // 
            // btnRescanPorts
            // 
            resources.ApplyResources(_btnRescanPorts, "btnRescanPorts");
            _btnRescanPorts.Name = "_btnRescanPorts";
            _btnRescanPorts.UseVisualStyleBackColor = true;
            // 
            // cbPorts
            // 
            _cbPorts.FormattingEnabled = true;
            resources.ApplyResources(_cbPorts, "cbPorts");
            _cbPorts.Name = "_cbPorts";
            // 
            // btnConnect
            // 
            resources.ApplyResources(_btnConnect, "btnConnect");
            _btnConnect.Name = "_btnConnect";
            _btnConnect.Tag = "COM";
            _btnConnect.UseVisualStyleBackColor = true;
            // 
            // cbBaud
            // 
            _cbBaud.FormattingEnabled = true;
            _cbBaud.Items.AddRange(new object[] { resources.GetString("cbBaud.Items"), resources.GetString("cbBaud.Items1") });
            resources.ApplyResources(_cbBaud, "cbBaud");
            _cbBaud.Name = "_cbBaud";
            // 
            // tbGrblIP
            // 
            tbGrblIP.Controls.Add(_btnIPConnect);
            tbGrblIP.Controls.Add(tbIPAddress);
            resources.ApplyResources(tbGrblIP, "tbGrblIP");
            tbGrblIP.Name = "tbGrblIP";
            tbGrblIP.UseVisualStyleBackColor = true;
            // 
            // btnIPConnect
            // 
            resources.ApplyResources(_btnIPConnect, "btnIPConnect");
            _btnIPConnect.Name = "_btnIPConnect";
            _btnIPConnect.Tag = "IP";
            _btnIPConnect.UseVisualStyleBackColor = true;
            // 
            // tbIPAddress
            // 
            resources.ApplyResources(tbIPAddress, "tbIPAddress");
            tbIPAddress.Name = "tbIPAddress";
            ToolTip1.SetToolTip(tbIPAddress, resources.GetString("tbIPAddress.ToolTip"));
            // 
            // gbPosition
            // 
            gbPosition.Controls.Add(tabCtlPosition);
            resources.ApplyResources(gbPosition, "gbPosition");
            gbPosition.FlatStyle = FlatStyle.Popup;
            gbPosition.Name = "gbPosition";
            gbPosition.TabStop = false;
            // 
            // tabCtlPosition
            // 
            tabCtlPosition.Controls.Add(tpWork);
            tabCtlPosition.Controls.Add(tpOffsets);
            resources.ApplyResources(tabCtlPosition, "tabCtlPosition");
            tabCtlPosition.Name = "tabCtlPosition";
            tabCtlPosition.SelectedIndex = 0;
            // 
            // tpWork
            // 
            tpWork.Controls.Add(Panel5);
            tpWork.Controls.Add(Panel4);
            tpWork.Controls.Add(Panel3);
            tpWork.Controls.Add(GroupBox1);
            tpWork.Controls.Add(_btnWorkSoftHome);
            tpWork.Controls.Add(_btnHome);
            tpWork.Controls.Add(_btnWorkSpclPosition);
            tpWork.Controls.Add(Label3);
            tpWork.Controls.Add(_btnWork0);
            tpWork.Controls.Add(Label2);
            tpWork.Controls.Add(_btnWorkX0);
            tpWork.Controls.Add(Label1);
            tpWork.Controls.Add(_btnWorkZ0);
            tpWork.Controls.Add(_btnWorkY0);
            resources.ApplyResources(tpWork, "tpWork");
            tpWork.Name = "tpWork";
            tpWork.UseVisualStyleBackColor = true;
            // 
            // Panel5
            // 
            Panel5.BackColor = SystemColors.Control;
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(_tbWorkZ);
            Panel5.Controls.Add(tbMachZ);
            resources.ApplyResources(Panel5, "Panel5");
            Panel5.Name = "Panel5";
            // 
            // tbWorkZ
            // 
            _tbWorkZ.BorderStyle = BorderStyle.None;
            resources.ApplyResources(_tbWorkZ, "tbWorkZ");
            _tbWorkZ.Name = "_tbWorkZ";
            _tbWorkZ.Tag = "Z";
            ToolTip1.SetToolTip(_tbWorkZ, resources.GetString("tbWorkZ.ToolTip"));
            // 
            // tbMachZ
            // 
            tbMachZ.BorderStyle = BorderStyle.None;
            resources.ApplyResources(tbMachZ, "tbMachZ");
            tbMachZ.Name = "tbMachZ";
            ToolTip1.SetToolTip(tbMachZ, resources.GetString("tbMachZ.ToolTip"));
            // 
            // Panel4
            // 
            Panel4.BackColor = SystemColors.Control;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_tbWorkY);
            Panel4.Controls.Add(tbMachY);
            resources.ApplyResources(Panel4, "Panel4");
            Panel4.Name = "Panel4";
            // 
            // tbWorkY
            // 
            _tbWorkY.BorderStyle = BorderStyle.None;
            resources.ApplyResources(_tbWorkY, "tbWorkY");
            _tbWorkY.Name = "_tbWorkY";
            _tbWorkY.Tag = "Y";
            ToolTip1.SetToolTip(_tbWorkY, resources.GetString("tbWorkY.ToolTip"));
            // 
            // tbMachY
            // 
            tbMachY.BorderStyle = BorderStyle.None;
            resources.ApplyResources(tbMachY, "tbMachY");
            tbMachY.Name = "tbMachY";
            ToolTip1.SetToolTip(tbMachY, resources.GetString("tbMachY.ToolTip"));
            // 
            // Panel3
            // 
            Panel3.BackColor = SystemColors.Control;
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(tbMachX);
            Panel3.Controls.Add(_tbWorkX);
            resources.ApplyResources(Panel3, "Panel3");
            Panel3.Name = "Panel3";
            // 
            // tbMachX
            // 
            tbMachX.BorderStyle = BorderStyle.None;
            resources.ApplyResources(tbMachX, "tbMachX");
            tbMachX.Name = "tbMachX";
            ToolTip1.SetToolTip(tbMachX, resources.GetString("tbMachX.ToolTip"));
            // 
            // tbWorkX
            // 
            _tbWorkX.BorderStyle = BorderStyle.None;
            resources.ApplyResources(_tbWorkX, "tbWorkX");
            _tbWorkX.Name = "_tbWorkX";
            _tbWorkX.Tag = "X";
            ToolTip1.SetToolTip(_tbWorkX, resources.GetString("tbWorkX.ToolTip"));
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(lblPositionCurrentOffset);
            resources.ApplyResources(GroupBox1, "GroupBox1");
            GroupBox1.Name = "GroupBox1";
            GroupBox1.TabStop = false;
            // 
            // lblPositionCurrentOffset
            // 
            resources.ApplyResources(lblPositionCurrentOffset, "lblPositionCurrentOffset");
            lblPositionCurrentOffset.Name = "lblPositionCurrentOffset";
            // 
            // btnWorkSoftHome
            // 
            resources.ApplyResources(_btnWorkSoftHome, "btnWorkSoftHome");
            _btnWorkSoftHome.Name = "_btnWorkSoftHome";
            _btnWorkSoftHome.Tag = "Spcl Posn1";
            ToolTip1.SetToolTip(_btnWorkSoftHome, resources.GetString("btnWorkSoftHome.ToolTip"));
            _btnWorkSoftHome.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            _btnHome.BackColor = Color.Transparent;
            resources.ApplyResources(_btnHome, "btnHome");
            _btnHome.Name = "_btnHome";
            _btnHome.Tag = "HomeCycle";
            ToolTip1.SetToolTip(_btnHome, resources.GetString("btnHome.ToolTip"));
            _btnHome.UseVisualStyleBackColor = false;
            // 
            // btnWorkSpclPosition
            // 
            resources.ApplyResources(_btnWorkSpclPosition, "btnWorkSpclPosition");
            _btnWorkSpclPosition.Name = "_btnWorkSpclPosition";
            _btnWorkSpclPosition.Tag = "Spcl Posn2";
            ToolTip1.SetToolTip(_btnWorkSpclPosition, resources.GetString("btnWorkSpclPosition.ToolTip"));
            _btnWorkSpclPosition.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            resources.ApplyResources(Label3, "Label3");
            Label3.Name = "Label3";
            // 
            // btnWork0
            // 
            resources.ApplyResources(_btnWork0, "btnWork0");
            _btnWork0.Name = "_btnWork0";
            _btnWork0.Tag = "ZeroXYZ";
            ToolTip1.SetToolTip(_btnWork0, resources.GetString("btnWork0.ToolTip"));
            _btnWork0.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            resources.ApplyResources(Label2, "Label2");
            Label2.Name = "Label2";
            // 
            // btnWorkX0
            // 
            resources.ApplyResources(_btnWorkX0, "btnWorkX0");
            _btnWorkX0.Name = "_btnWorkX0";
            _btnWorkX0.Tag = "X";
            ToolTip1.SetToolTip(_btnWorkX0, resources.GetString("btnWorkX0.ToolTip"));
            _btnWorkX0.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            resources.ApplyResources(Label1, "Label1");
            Label1.Name = "Label1";
            // 
            // btnWorkZ0
            // 
            resources.ApplyResources(_btnWorkZ0, "btnWorkZ0");
            _btnWorkZ0.Name = "_btnWorkZ0";
            _btnWorkZ0.Tag = "Z";
            ToolTip1.SetToolTip(_btnWorkZ0, resources.GetString("btnWorkZ0.ToolTip"));
            _btnWorkZ0.UseVisualStyleBackColor = true;
            // 
            // btnWorkY0
            // 
            resources.ApplyResources(_btnWorkY0, "btnWorkY0");
            _btnWorkY0.Name = "_btnWorkY0";
            _btnWorkY0.Tag = "Y";
            ToolTip1.SetToolTip(_btnWorkY0, resources.GetString("btnWorkY0.ToolTip"));
            _btnWorkY0.UseVisualStyleBackColor = true;
            // 
            // tpOffsets
            // 
            tpOffsets.Controls.Add(_btnSetOffsetG59);
            tpOffsets.Controls.Add(_btnSetOffsetG58);
            tpOffsets.Controls.Add(_btnSetOffsetG57);
            tpOffsets.Controls.Add(_btnSetOffsetG56);
            tpOffsets.Controls.Add(_btnSetOffsetG55);
            tpOffsets.Controls.Add(_btnSetOffsetG54);
            tpOffsets.Controls.Add(Label10);
            tpOffsets.Controls.Add(Label71);
            tpOffsets.Controls.Add(tbOffSetsMachZ);
            tpOffsets.Controls.Add(Label19);
            tpOffsets.Controls.Add(_tbOffsetsG56Y);
            tpOffsets.Controls.Add(tbOffSetsMachY);
            tpOffsets.Controls.Add(_tbOffsetsG56X);
            tpOffsets.Controls.Add(_tbOffsetsG56Z);
            tpOffsets.Controls.Add(tbOffSetsMachX);
            tpOffsets.Controls.Add(_btnOffsetsG57Zero);
            tpOffsets.Controls.Add(_tbOffsetsG54X);
            tpOffsets.Controls.Add(_btnOffsetsG56Zero);
            tpOffsets.Controls.Add(_tbOffsetsG54Y);
            tpOffsets.Controls.Add(_tbOffsetsG57Z);
            tpOffsets.Controls.Add(_btnOffsetsSave);
            tpOffsets.Controls.Add(_tbOffsetsG55X);
            tpOffsets.Controls.Add(_tbOffsetsG54Z);
            tpOffsets.Controls.Add(_tbOffsetsG57Y);
            tpOffsets.Controls.Add(_btnOffsetsRetrieve);
            tpOffsets.Controls.Add(_tbOffsetsG55Y);
            tpOffsets.Controls.Add(_btnOffsetsG54Zero);
            tpOffsets.Controls.Add(_tbOffsetsG57X);
            tpOffsets.Controls.Add(_btnOffsetsLoad);
            tpOffsets.Controls.Add(_tbOffsetsG55Z);
            tpOffsets.Controls.Add(_tbOffsetsG59X);
            tpOffsets.Controls.Add(_btnOffsetsG58Zero);
            tpOffsets.Controls.Add(_btnOffsetsG43Zero);
            tpOffsets.Controls.Add(_tbOffsetsG59Y);
            tpOffsets.Controls.Add(_tbOffsetsG43Z);
            tpOffsets.Controls.Add(_btnOffsetsG55Zero);
            tpOffsets.Controls.Add(_tbOffsetsG59Z);
            tpOffsets.Controls.Add(_tbOffsetsG58Z);
            tpOffsets.Controls.Add(Label60);
            tpOffsets.Controls.Add(_tbOffsetsG58Y);
            tpOffsets.Controls.Add(Label20);
            tpOffsets.Controls.Add(Label43);
            tpOffsets.Controls.Add(_btnOffsetsG59Zero);
            tpOffsets.Controls.Add(_tbOffsetsG58X);
            tpOffsets.Controls.Add(Label21);
            resources.ApplyResources(tpOffsets, "tpOffsets");
            tpOffsets.Name = "tpOffsets";
            tpOffsets.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG59
            // 
            resources.ApplyResources(_btnSetOffsetG59, "btnSetOffsetG59");
            _btnSetOffsetG59.Name = "_btnSetOffsetG59";
            _btnSetOffsetG59.Tag = "G59";
            ToolTip1.SetToolTip(_btnSetOffsetG59, resources.GetString("btnSetOffsetG59.ToolTip"));
            _btnSetOffsetG59.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG58
            // 
            resources.ApplyResources(_btnSetOffsetG58, "btnSetOffsetG58");
            _btnSetOffsetG58.Name = "_btnSetOffsetG58";
            _btnSetOffsetG58.Tag = "G58";
            ToolTip1.SetToolTip(_btnSetOffsetG58, resources.GetString("btnSetOffsetG58.ToolTip"));
            _btnSetOffsetG58.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG57
            // 
            resources.ApplyResources(_btnSetOffsetG57, "btnSetOffsetG57");
            _btnSetOffsetG57.Name = "_btnSetOffsetG57";
            _btnSetOffsetG57.Tag = "G57";
            ToolTip1.SetToolTip(_btnSetOffsetG57, resources.GetString("btnSetOffsetG57.ToolTip"));
            _btnSetOffsetG57.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG56
            // 
            resources.ApplyResources(_btnSetOffsetG56, "btnSetOffsetG56");
            _btnSetOffsetG56.Name = "_btnSetOffsetG56";
            _btnSetOffsetG56.Tag = "G56";
            ToolTip1.SetToolTip(_btnSetOffsetG56, resources.GetString("btnSetOffsetG56.ToolTip"));
            _btnSetOffsetG56.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG55
            // 
            resources.ApplyResources(_btnSetOffsetG55, "btnSetOffsetG55");
            _btnSetOffsetG55.Name = "_btnSetOffsetG55";
            _btnSetOffsetG55.Tag = "G55";
            ToolTip1.SetToolTip(_btnSetOffsetG55, resources.GetString("btnSetOffsetG55.ToolTip"));
            _btnSetOffsetG55.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG54
            // 
            resources.ApplyResources(_btnSetOffsetG54, "btnSetOffsetG54");
            _btnSetOffsetG54.Name = "_btnSetOffsetG54";
            _btnSetOffsetG54.Tag = "G54";
            ToolTip1.SetToolTip(_btnSetOffsetG54, resources.GetString("btnSetOffsetG54.ToolTip"));
            _btnSetOffsetG54.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            resources.ApplyResources(Label10, "Label10");
            Label10.Name = "Label10";
            // 
            // Label71
            // 
            resources.ApplyResources(Label71, "Label71");
            Label71.Name = "Label71";
            // 
            // tbOffSetsMachZ
            // 
            resources.ApplyResources(tbOffSetsMachZ, "tbOffSetsMachZ");
            tbOffSetsMachZ.Name = "tbOffSetsMachZ";
            tbOffSetsMachZ.Tag = "G28Z";
            ToolTip1.SetToolTip(tbOffSetsMachZ, resources.GetString("tbOffSetsMachZ.ToolTip"));
            // 
            // Label19
            // 
            resources.ApplyResources(Label19, "Label19");
            Label19.Name = "Label19";
            // 
            // tbOffsetsG56Y
            // 
            resources.ApplyResources(_tbOffsetsG56Y, "tbOffsetsG56Y");
            _tbOffsetsG56Y.Name = "_tbOffsetsG56Y";
            _tbOffsetsG56Y.Tag = "G56Y";
            // 
            // tbOffSetsMachY
            // 
            resources.ApplyResources(tbOffSetsMachY, "tbOffSetsMachY");
            tbOffSetsMachY.Name = "tbOffSetsMachY";
            tbOffSetsMachY.Tag = "G28Y";
            ToolTip1.SetToolTip(tbOffSetsMachY, resources.GetString("tbOffSetsMachY.ToolTip"));
            // 
            // tbOffsetsG56X
            // 
            resources.ApplyResources(_tbOffsetsG56X, "tbOffsetsG56X");
            _tbOffsetsG56X.Name = "_tbOffsetsG56X";
            _tbOffsetsG56X.Tag = "G56X";
            // 
            // tbOffsetsG56Z
            // 
            resources.ApplyResources(_tbOffsetsG56Z, "tbOffsetsG56Z");
            _tbOffsetsG56Z.Name = "_tbOffsetsG56Z";
            _tbOffsetsG56Z.Tag = "G56Z";
            // 
            // tbOffSetsMachX
            // 
            resources.ApplyResources(tbOffSetsMachX, "tbOffSetsMachX");
            tbOffSetsMachX.Name = "tbOffSetsMachX";
            tbOffSetsMachX.Tag = "G28X";
            ToolTip1.SetToolTip(tbOffSetsMachX, resources.GetString("tbOffSetsMachX.ToolTip"));
            // 
            // btnOffsetsG57Zero
            // 
            resources.ApplyResources(_btnOffsetsG57Zero, "btnOffsetsG57Zero");
            _btnOffsetsG57Zero.Name = "_btnOffsetsG57Zero";
            _btnOffsetsG57Zero.Tag = "G57Zero";
            _btnOffsetsG57Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG54X
            // 
            resources.ApplyResources(_tbOffsetsG54X, "tbOffsetsG54X");
            _tbOffsetsG54X.Name = "_tbOffsetsG54X";
            _tbOffsetsG54X.Tag = "G54X";
            // 
            // btnOffsetsG56Zero
            // 
            resources.ApplyResources(_btnOffsetsG56Zero, "btnOffsetsG56Zero");
            _btnOffsetsG56Zero.Name = "_btnOffsetsG56Zero";
            _btnOffsetsG56Zero.Tag = "G56Zero";
            _btnOffsetsG56Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG54Y
            // 
            resources.ApplyResources(_tbOffsetsG54Y, "tbOffsetsG54Y");
            _tbOffsetsG54Y.Name = "_tbOffsetsG54Y";
            _tbOffsetsG54Y.Tag = "G54Y";
            // 
            // tbOffsetsG57Z
            // 
            resources.ApplyResources(_tbOffsetsG57Z, "tbOffsetsG57Z");
            _tbOffsetsG57Z.Name = "_tbOffsetsG57Z";
            _tbOffsetsG57Z.Tag = "G57Z";
            // 
            // btnOffsetsSave
            // 
            resources.ApplyResources(_btnOffsetsSave, "btnOffsetsSave");
            _btnOffsetsSave.Name = "_btnOffsetsSave";
            ToolTip1.SetToolTip(_btnOffsetsSave, resources.GetString("btnOffsetsSave.ToolTip"));
            _btnOffsetsSave.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG55X
            // 
            resources.ApplyResources(_tbOffsetsG55X, "tbOffsetsG55X");
            _tbOffsetsG55X.Name = "_tbOffsetsG55X";
            _tbOffsetsG55X.Tag = "G55X";
            // 
            // tbOffsetsG54Z
            // 
            resources.ApplyResources(_tbOffsetsG54Z, "tbOffsetsG54Z");
            _tbOffsetsG54Z.Name = "_tbOffsetsG54Z";
            _tbOffsetsG54Z.Tag = "G54Z";
            // 
            // tbOffsetsG57Y
            // 
            resources.ApplyResources(_tbOffsetsG57Y, "tbOffsetsG57Y");
            _tbOffsetsG57Y.Name = "_tbOffsetsG57Y";
            _tbOffsetsG57Y.Tag = "G57Y";
            // 
            // btnOffsetsRetrieve
            // 
            resources.ApplyResources(_btnOffsetsRetrieve, "btnOffsetsRetrieve");
            _btnOffsetsRetrieve.Name = "_btnOffsetsRetrieve";
            ToolTip1.SetToolTip(_btnOffsetsRetrieve, resources.GetString("btnOffsetsRetrieve.ToolTip"));
            _btnOffsetsRetrieve.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG55Y
            // 
            resources.ApplyResources(_tbOffsetsG55Y, "tbOffsetsG55Y");
            _tbOffsetsG55Y.Name = "_tbOffsetsG55Y";
            _tbOffsetsG55Y.Tag = "G55Y";
            // 
            // btnOffsetsG54Zero
            // 
            resources.ApplyResources(_btnOffsetsG54Zero, "btnOffsetsG54Zero");
            _btnOffsetsG54Zero.Name = "_btnOffsetsG54Zero";
            _btnOffsetsG54Zero.Tag = "G54Zero";
            _btnOffsetsG54Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG57X
            // 
            resources.ApplyResources(_tbOffsetsG57X, "tbOffsetsG57X");
            _tbOffsetsG57X.Name = "_tbOffsetsG57X";
            _tbOffsetsG57X.Tag = "G57X";
            // 
            // btnOffsetsLoad
            // 
            resources.ApplyResources(_btnOffsetsLoad, "btnOffsetsLoad");
            _btnOffsetsLoad.Name = "_btnOffsetsLoad";
            ToolTip1.SetToolTip(_btnOffsetsLoad, resources.GetString("btnOffsetsLoad.ToolTip"));
            _btnOffsetsLoad.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG55Z
            // 
            resources.ApplyResources(_tbOffsetsG55Z, "tbOffsetsG55Z");
            _tbOffsetsG55Z.Name = "_tbOffsetsG55Z";
            _tbOffsetsG55Z.Tag = "G55Z";
            // 
            // tbOffsetsG59X
            // 
            resources.ApplyResources(_tbOffsetsG59X, "tbOffsetsG59X");
            _tbOffsetsG59X.Name = "_tbOffsetsG59X";
            _tbOffsetsG59X.Tag = "G59X";
            // 
            // btnOffsetsG58Zero
            // 
            resources.ApplyResources(_btnOffsetsG58Zero, "btnOffsetsG58Zero");
            _btnOffsetsG58Zero.Name = "_btnOffsetsG58Zero";
            _btnOffsetsG58Zero.Tag = "G58Zero";
            _btnOffsetsG58Zero.UseVisualStyleBackColor = true;
            // 
            // btnOffsetsG43Zero
            // 
            resources.ApplyResources(_btnOffsetsG43Zero, "btnOffsetsG43Zero");
            _btnOffsetsG43Zero.Name = "_btnOffsetsG43Zero";
            _btnOffsetsG43Zero.Tag = "G43Zero";
            _btnOffsetsG43Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG59Y
            // 
            resources.ApplyResources(_tbOffsetsG59Y, "tbOffsetsG59Y");
            _tbOffsetsG59Y.Name = "_tbOffsetsG59Y";
            _tbOffsetsG59Y.Tag = "G59Y";
            // 
            // tbOffsetsG43Z
            // 
            resources.ApplyResources(_tbOffsetsG43Z, "tbOffsetsG43Z");
            _tbOffsetsG43Z.Name = "_tbOffsetsG43Z";
            _tbOffsetsG43Z.Tag = "G43Z";
            // 
            // btnOffsetsG55Zero
            // 
            resources.ApplyResources(_btnOffsetsG55Zero, "btnOffsetsG55Zero");
            _btnOffsetsG55Zero.Name = "_btnOffsetsG55Zero";
            _btnOffsetsG55Zero.Tag = "G55Zero";
            _btnOffsetsG55Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG59Z
            // 
            resources.ApplyResources(_tbOffsetsG59Z, "tbOffsetsG59Z");
            _tbOffsetsG59Z.Name = "_tbOffsetsG59Z";
            _tbOffsetsG59Z.Tag = "G59Z";
            // 
            // tbOffsetsG58Z
            // 
            resources.ApplyResources(_tbOffsetsG58Z, "tbOffsetsG58Z");
            _tbOffsetsG58Z.Name = "_tbOffsetsG58Z";
            _tbOffsetsG58Z.Tag = "G58Z";
            // 
            // Label60
            // 
            resources.ApplyResources(Label60, "Label60");
            Label60.Name = "Label60";
            // 
            // tbOffsetsG58Y
            // 
            resources.ApplyResources(_tbOffsetsG58Y, "tbOffsetsG58Y");
            _tbOffsetsG58Y.Name = "_tbOffsetsG58Y";
            _tbOffsetsG58Y.Tag = "G58Y";
            // 
            // Label20
            // 
            resources.ApplyResources(Label20, "Label20");
            Label20.Name = "Label20";
            // 
            // Label43
            // 
            resources.ApplyResources(Label43, "Label43");
            Label43.Name = "Label43";
            // 
            // btnOffsetsG59Zero
            // 
            resources.ApplyResources(_btnOffsetsG59Zero, "btnOffsetsG59Zero");
            _btnOffsetsG59Zero.Name = "_btnOffsetsG59Zero";
            _btnOffsetsG59Zero.Tag = "G59Zero";
            _btnOffsetsG59Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG58X
            // 
            resources.ApplyResources(_tbOffsetsG58X, "tbOffsetsG58X");
            _tbOffsetsG58X.Name = "_tbOffsetsG58X";
            _tbOffsetsG58X.Tag = "G58X";
            // 
            // Label21
            // 
            resources.ApplyResources(Label21, "Label21");
            Label21.Name = "Label21";
            // 
            // tabPgSettings
            // 
            tabPgSettings.Controls.Add(gbMiscInfo);
            tabPgSettings.Controls.Add(gbGrblSettings);
            tabPgSettings.Controls.Add(gbSettingsOffsets);
            tabPgSettings.Controls.Add(Label42);
            tabPgSettings.Controls.Add(gbSettingsMisc);
            tabPgSettings.Controls.Add(gbSettingsPosition);
            tabPgSettings.Controls.Add(gbSettingsJogging);
            resources.ApplyResources(tabPgSettings, "tabPgSettings");
            tabPgSettings.Name = "tabPgSettings";
            tabPgSettings.UseVisualStyleBackColor = true;
            // 
            // gbMiscInfo
            // 
            gbMiscInfo.Controls.Add(Label49);
            gbMiscInfo.Controls.Add(tbGrblOptions);
            gbMiscInfo.Controls.Add(Label48);
            gbMiscInfo.Controls.Add(tbGrblVersion);
            resources.ApplyResources(gbMiscInfo, "gbMiscInfo");
            gbMiscInfo.Name = "gbMiscInfo";
            gbMiscInfo.TabStop = false;
            // 
            // Label49
            // 
            resources.ApplyResources(Label49, "Label49");
            Label49.Name = "Label49";
            // 
            // tbGrblOptions
            // 
            resources.ApplyResources(tbGrblOptions, "tbGrblOptions");
            tbGrblOptions.Name = "tbGrblOptions";
            // 
            // Label48
            // 
            resources.ApplyResources(Label48, "Label48");
            Label48.Name = "Label48";
            // 
            // tbGrblVersion
            // 
            resources.ApplyResources(tbGrblVersion, "tbGrblVersion");
            tbGrblVersion.Name = "tbGrblVersion";
            // 
            // gbGrblSettings
            // 
            gbGrblSettings.Controls.Add(Label4);
            gbGrblSettings.Controls.Add(tbSettingsGrblLastParam);
            gbGrblSettings.Controls.Add(_dgGrblSettings);
            gbGrblSettings.Controls.Add(_btnSettingsGrbl);
            resources.ApplyResources(gbGrblSettings, "gbGrblSettings");
            gbGrblSettings.Name = "gbGrblSettings";
            gbGrblSettings.TabStop = false;
            // 
            // Label4
            // 
            resources.ApplyResources(Label4, "Label4");
            Label4.Name = "Label4";
            // 
            // dgGrblSettings
            // 
            _dgGrblSettings.AllowUserToAddRows = false;
            _dgGrblSettings.AllowUserToDeleteRows = false;
            _dgGrblSettings.AllowUserToResizeColumns = false;
            _dgGrblSettings.AllowUserToResizeRows = false;
            _dgGrblSettings.BackgroundColor = SystemColors.Window;
            _dgGrblSettings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(_dgGrblSettings, "dgGrblSettings");
            _dgGrblSettings.MultiSelect = false;
            _dgGrblSettings.Name = "_dgGrblSettings";
            _dgGrblSettings.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ToolTip1.SetToolTip(_dgGrblSettings, resources.GetString("dgGrblSettings.ToolTip"));
            // 
            // btnSettingsGrbl
            // 
            resources.ApplyResources(_btnSettingsGrbl, "btnSettingsGrbl");
            _btnSettingsGrbl.Name = "_btnSettingsGrbl";
            _btnSettingsGrbl.UseVisualStyleBackColor = true;
            // 
            // gbSettingsOffsets
            // 
            gbSettingsOffsets.Controls.Add(_btnOffsetsG28Set);
            gbSettingsOffsets.Controls.Add(_btnSettingsRetrieveLocations);
            gbSettingsOffsets.Controls.Add(Label7);
            gbSettingsOffsets.Controls.Add(Label18);
            gbSettingsOffsets.Controls.Add(tbOffsetsG30Y);
            gbSettingsOffsets.Controls.Add(tbOffsetsG30X);
            gbSettingsOffsets.Controls.Add(tbOffsetsG30Z);
            gbSettingsOffsets.Controls.Add(tbOffsetsG28X);
            gbSettingsOffsets.Controls.Add(_btnOffsetsG30Set);
            gbSettingsOffsets.Controls.Add(tbOffsetsG28Y);
            gbSettingsOffsets.Controls.Add(Label68);
            gbSettingsOffsets.Controls.Add(tbOffsetsG28Z);
            gbSettingsOffsets.Controls.Add(Label69);
            resources.ApplyResources(gbSettingsOffsets, "gbSettingsOffsets");
            gbSettingsOffsets.Name = "gbSettingsOffsets";
            gbSettingsOffsets.TabStop = false;
            // 
            // btnOffsetsG28Set
            // 
            resources.ApplyResources(_btnOffsetsG28Set, "btnOffsetsG28Set");
            _btnOffsetsG28Set.Name = "_btnOffsetsG28Set";
            _btnOffsetsG28Set.Tag = "G28Set";
            ToolTip1.SetToolTip(_btnOffsetsG28Set, resources.GetString("btnOffsetsG28Set.ToolTip"));
            _btnOffsetsG28Set.UseVisualStyleBackColor = true;
            // 
            // btnSettingsRetrieveLocations
            // 
            resources.ApplyResources(_btnSettingsRetrieveLocations, "btnSettingsRetrieveLocations");
            _btnSettingsRetrieveLocations.Name = "_btnSettingsRetrieveLocations";
            ToolTip1.SetToolTip(_btnSettingsRetrieveLocations, resources.GetString("btnSettingsRetrieveLocations.ToolTip"));
            _btnSettingsRetrieveLocations.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            resources.ApplyResources(Label7, "Label7");
            Label7.Name = "Label7";
            // 
            // Label18
            // 
            resources.ApplyResources(Label18, "Label18");
            Label18.Name = "Label18";
            // 
            // tbOffsetsG30Y
            // 
            resources.ApplyResources(tbOffsetsG30Y, "tbOffsetsG30Y");
            tbOffsetsG30Y.Name = "tbOffsetsG30Y";
            tbOffsetsG30Y.Tag = "G30Y";
            // 
            // tbOffsetsG30X
            // 
            resources.ApplyResources(tbOffsetsG30X, "tbOffsetsG30X");
            tbOffsetsG30X.Name = "tbOffsetsG30X";
            tbOffsetsG30X.Tag = "G30X";
            // 
            // tbOffsetsG30Z
            // 
            resources.ApplyResources(tbOffsetsG30Z, "tbOffsetsG30Z");
            tbOffsetsG30Z.Name = "tbOffsetsG30Z";
            tbOffsetsG30Z.Tag = "G30Z";
            // 
            // tbOffsetsG28X
            // 
            resources.ApplyResources(tbOffsetsG28X, "tbOffsetsG28X");
            tbOffsetsG28X.Name = "tbOffsetsG28X";
            tbOffsetsG28X.Tag = "G28X";
            // 
            // btnOffsetsG30Set
            // 
            resources.ApplyResources(_btnOffsetsG30Set, "btnOffsetsG30Set");
            _btnOffsetsG30Set.Name = "_btnOffsetsG30Set";
            _btnOffsetsG30Set.Tag = "G30Set";
            ToolTip1.SetToolTip(_btnOffsetsG30Set, resources.GetString("btnOffsetsG30Set.ToolTip"));
            _btnOffsetsG30Set.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG28Y
            // 
            resources.ApplyResources(tbOffsetsG28Y, "tbOffsetsG28Y");
            tbOffsetsG28Y.Name = "tbOffsetsG28Y";
            tbOffsetsG28Y.Tag = "G28Y";
            // 
            // Label68
            // 
            resources.ApplyResources(Label68, "Label68");
            Label68.Name = "Label68";
            // 
            // tbOffsetsG28Z
            // 
            resources.ApplyResources(tbOffsetsG28Z, "tbOffsetsG28Z");
            tbOffsetsG28Z.Name = "tbOffsetsG28Z";
            tbOffsetsG28Z.Tag = "G28Z";
            // 
            // Label69
            // 
            resources.ApplyResources(Label69, "Label69");
            Label69.Name = "Label69";
            // 
            // Label42
            // 
            resources.ApplyResources(Label42, "Label42");
            Label42.Name = "Label42";
            // 
            // gbSettingsMisc
            // 
            gbSettingsMisc.Controls.Add(Label52);
            gbSettingsMisc.Controls.Add(tbTruncationDigits);
            gbSettingsMisc.Controls.Add(tbSettingsDefaultExt);
            gbSettingsMisc.Controls.Add(Label5);
            gbSettingsMisc.Controls.Add(Label6);
            gbSettingsMisc.Controls.Add(tbSettingsStartupDelay);
            gbSettingsMisc.Controls.Add(_cbSettingsLeftHanded);
            gbSettingsMisc.Controls.Add(cbSettingsConnectOnLoad);
            gbSettingsMisc.Controls.Add(cbSettingsPauseOnError);
            gbSettingsMisc.Controls.Add(cbStatusPollEnable);
            gbSettingsMisc.Controls.Add(_btnSettingsRefreshMisc);
            gbSettingsMisc.Controls.Add(Label37);
            gbSettingsMisc.Controls.Add(Label36);
            gbSettingsMisc.Controls.Add(tbSettingsRBuffSize);
            gbSettingsMisc.Controls.Add(tbSettingsQSize);
            gbSettingsMisc.Controls.Add(Label26);
            gbSettingsMisc.Controls.Add(tbSettingsPollRate);
            resources.ApplyResources(gbSettingsMisc, "gbSettingsMisc");
            gbSettingsMisc.Name = "gbSettingsMisc";
            gbSettingsMisc.TabStop = false;
            // 
            // Label52
            // 
            resources.ApplyResources(Label52, "Label52");
            Label52.Name = "Label52";
            // 
            // Label5
            // 
            resources.ApplyResources(Label5, "Label5");
            Label5.Name = "Label5";
            // 
            // Label6
            // 
            resources.ApplyResources(Label6, "Label6");
            Label6.Name = "Label6";
            // 
            // tbSettingsStartupDelay
            // 
            tbSettingsStartupDelay.DataBindings.Add(new Binding("Text", My.MySettings.Default, "StartDelay", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsStartupDelay, "tbSettingsStartupDelay");
            tbSettingsStartupDelay.Name = "tbSettingsStartupDelay";
            tbSettingsStartupDelay.Text = My.MySettings.Default.StartDelay;
            // 
            // btnSettingsRefreshMisc
            // 
            resources.ApplyResources(_btnSettingsRefreshMisc, "btnSettingsRefreshMisc");
            _btnSettingsRefreshMisc.Name = "_btnSettingsRefreshMisc";
            _btnSettingsRefreshMisc.Tag = "Misc";
            _btnSettingsRefreshMisc.UseVisualStyleBackColor = true;
            // 
            // Label37
            // 
            resources.ApplyResources(Label37, "Label37");
            Label37.Name = "Label37";
            // 
            // Label36
            // 
            resources.ApplyResources(Label36, "Label36");
            Label36.Name = "Label36";
            // 
            // Label26
            // 
            resources.ApplyResources(Label26, "Label26");
            Label26.Name = "Label26";
            // 
            // gbSettingsPosition
            // 
            gbSettingsPosition.Controls.Add(Label8);
            gbSettingsPosition.Controls.Add(tbSettingsSpclPosition2);
            gbSettingsPosition.Controls.Add(_btnSettingsRefreshPosition);
            gbSettingsPosition.Controls.Add(Label29);
            gbSettingsPosition.Controls.Add(tbWorkZ0Cmd);
            gbSettingsPosition.Controls.Add(Label28);
            gbSettingsPosition.Controls.Add(tbWorkY0Cmd);
            gbSettingsPosition.Controls.Add(Label13);
            gbSettingsPosition.Controls.Add(Label12);
            gbSettingsPosition.Controls.Add(tbWorkX0Cmd);
            gbSettingsPosition.Controls.Add(tbSettingsZeroXYZCmd);
            gbSettingsPosition.Controls.Add(Label11);
            gbSettingsPosition.Controls.Add(tbSettingsSpclPosition1);
            resources.ApplyResources(gbSettingsPosition, "gbSettingsPosition");
            gbSettingsPosition.Name = "gbSettingsPosition";
            gbSettingsPosition.TabStop = false;
            // 
            // Label8
            // 
            resources.ApplyResources(Label8, "Label8");
            Label8.Name = "Label8";
            // 
            // btnSettingsRefreshPosition
            // 
            resources.ApplyResources(_btnSettingsRefreshPosition, "btnSettingsRefreshPosition");
            _btnSettingsRefreshPosition.Name = "_btnSettingsRefreshPosition";
            _btnSettingsRefreshPosition.Tag = "Position";
            _btnSettingsRefreshPosition.UseVisualStyleBackColor = true;
            // 
            // Label29
            // 
            resources.ApplyResources(Label29, "Label29");
            Label29.Name = "Label29";
            // 
            // Label28
            // 
            resources.ApplyResources(Label28, "Label28");
            Label28.Name = "Label28";
            // 
            // Label13
            // 
            resources.ApplyResources(Label13, "Label13");
            Label13.Name = "Label13";
            // 
            // Label12
            // 
            resources.ApplyResources(Label12, "Label12");
            Label12.Name = "Label12";
            // 
            // Label11
            // 
            resources.ApplyResources(Label11, "Label11");
            Label11.Name = "Label11";
            ToolTip1.SetToolTip(Label11, resources.GetString("Label11.ToolTip"));
            // 
            // gbSettingsJogging
            // 
            gbSettingsJogging.Controls.Add(cbSettingsKeyboardJogging);
            gbSettingsJogging.Controls.Add(_btnSettingsRefreshJogging);
            gbSettingsJogging.Controls.Add(Label41);
            gbSettingsJogging.Controls.Add(Label40);
            gbSettingsJogging.Controls.Add(Label39);
            gbSettingsJogging.Controls.Add(Label38);
            gbSettingsJogging.Controls.Add(tbSettingsZRepeat);
            gbSettingsJogging.Controls.Add(tbSettingsYRepeat);
            gbSettingsJogging.Controls.Add(tbSettingsXRepeat);
            gbSettingsJogging.Controls.Add(Label35);
            gbSettingsJogging.Controls.Add(Label34);
            gbSettingsJogging.Controls.Add(Label32);
            gbSettingsJogging.Controls.Add(tbSettingsFRMetric);
            gbSettingsJogging.Controls.Add(Label33);
            gbSettingsJogging.Controls.Add(tbSettingsFIMetric);
            gbSettingsJogging.Controls.Add(Label31);
            gbSettingsJogging.Controls.Add(tbSettingsFRImperial);
            gbSettingsJogging.Controls.Add(Label30);
            gbSettingsJogging.Controls.Add(_cbSettingsMetric);
            gbSettingsJogging.Controls.Add(tbSettingsFIImperial);
            resources.ApplyResources(gbSettingsJogging, "gbSettingsJogging");
            gbSettingsJogging.Name = "gbSettingsJogging";
            gbSettingsJogging.TabStop = false;
            // 
            // btnSettingsRefreshJogging
            // 
            resources.ApplyResources(_btnSettingsRefreshJogging, "btnSettingsRefreshJogging");
            _btnSettingsRefreshJogging.Name = "_btnSettingsRefreshJogging";
            _btnSettingsRefreshJogging.Tag = "Jogging";
            _btnSettingsRefreshJogging.UseVisualStyleBackColor = true;
            // 
            // Label41
            // 
            resources.ApplyResources(Label41, "Label41");
            Label41.Name = "Label41";
            // 
            // Label40
            // 
            resources.ApplyResources(Label40, "Label40");
            Label40.Name = "Label40";
            // 
            // Label39
            // 
            resources.ApplyResources(Label39, "Label39");
            Label39.Name = "Label39";
            // 
            // Label38
            // 
            resources.ApplyResources(Label38, "Label38");
            Label38.Name = "Label38";
            // 
            // Label35
            // 
            resources.ApplyResources(Label35, "Label35");
            Label35.Name = "Label35";
            // 
            // Label34
            // 
            resources.ApplyResources(Label34, "Label34");
            Label34.Name = "Label34";
            // 
            // Label32
            // 
            resources.ApplyResources(Label32, "Label32");
            Label32.Name = "Label32";
            // 
            // Label33
            // 
            resources.ApplyResources(Label33, "Label33");
            Label33.Name = "Label33";
            // 
            // Label31
            // 
            resources.ApplyResources(Label31, "Label31");
            Label31.Name = "Label31";
            // 
            // Label30
            // 
            resources.ApplyResources(Label30, "Label30");
            Label30.Name = "Label30";
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(gbEditor);
            TabPage1.Controls.Add(_btnCancel);
            TabPage1.Controls.Add(_btnOK);
            TabPage1.Controls.Add(_dgMacros);
            TabPage1.Controls.Add(lblStatusLabel);
            TabPage1.Controls.Add(_btnDeleteMacro);
            resources.ApplyResources(TabPage1, "TabPage1");
            TabPage1.Name = "TabPage1";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // gbEditor
            // 
            gbEditor.Controls.Add(_btnAdd);
            gbEditor.Controls.Add(lblGCode);
            gbEditor.Controls.Add(_tbGCode);
            gbEditor.Controls.Add(lblName);
            gbEditor.Controls.Add(_tbName);
            resources.ApplyResources(gbEditor, "gbEditor");
            gbEditor.Name = "gbEditor";
            gbEditor.TabStop = false;
            // 
            // btnAdd
            // 
            resources.ApplyResources(_btnAdd, "btnAdd");
            _btnAdd.Name = "_btnAdd";
            _btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblGCode
            // 
            resources.ApplyResources(lblGCode, "lblGCode");
            lblGCode.Name = "lblGCode";
            // 
            // tbGCode
            // 
            _tbGCode.AcceptsReturn = true;
            resources.ApplyResources(_tbGCode, "tbGCode");
            _tbGCode.Name = "_tbGCode";
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.Name = "lblName";
            // 
            // tbName
            // 
            resources.ApplyResources(_tbName, "tbName");
            _tbName.Name = "_tbName";
            // 
            // btnCancel
            // 
            _btnCancel.DialogResult = DialogResult.Cancel;
            resources.ApplyResources(_btnCancel, "btnCancel");
            _btnCancel.Name = "_btnCancel";
            _btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            resources.ApplyResources(_btnOK, "btnOK");
            _btnOK.Name = "_btnOK";
            _btnOK.UseVisualStyleBackColor = true;
            // 
            // dgMacros
            // 
            _dgMacros.AllowUserToAddRows = false;
            _dgMacros.AllowUserToDeleteRows = false;
            _dgMacros.AllowUserToResizeColumns = false;
            _dgMacros.AllowUserToResizeRows = false;
            _dgMacros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgMacros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            _dgMacros.EditMode = DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(_dgMacros, "dgMacros");
            _dgMacros.Name = "_dgMacros";
            _dgMacros.ReadOnly = true;
            _dgMacros.RowHeadersVisible = false;
            _dgMacros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            _dgMacros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column1
            // 
            resources.ApplyResources(Column1, "Column1");
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(Column2, "Column2");
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // lblStatusLabel
            // 
            resources.ApplyResources(lblStatusLabel, "lblStatusLabel");
            lblStatusLabel.Name = "lblStatusLabel";
            // 
            // btnDeleteMacro
            // 
            resources.ApplyResources(_btnDeleteMacro, "btnDeleteMacro");
            _btnDeleteMacro.Name = "_btnDeleteMacro";
            _btnDeleteMacro.UseVisualStyleBackColor = true;
            // 
            // ofdGcodeFile
            // 
            ofdGcodeFile.DefaultExt = "ngc";
            ofdGcodeFile.FileName = "*.*";
            resources.ApplyResources(ofdGcodeFile, "ofdGcodeFile");
            // 
            // sfdOffsets
            // 
            sfdOffsets.DefaultExt = "xml";
            resources.ApplyResources(sfdOffsets, "sfdOffsets");
            // 
            // ofdOffsets
            // 
            ofdOffsets.DefaultExt = "xml";
            ofdOffsets.FileName = "OpenFileDialog1";
            resources.ApplyResources(ofdOffsets, "ofdOffsets");
            // 
            // cbVerbose
            // 
            resources.ApplyResources(cbVerbose, "cbVerbose");
            cbVerbose.Checked = My.MySettings.Default.StatusVerbose;
            cbVerbose.DataBindings.Add(new Binding("Checked", My.MySettings.Default, "statusVerbose", true, DataSourceUpdateMode.OnPropertyChanged));
            cbVerbose.Name = "cbVerbose";
            cbVerbose.UseVisualStyleBackColor = true;
            // 
            // tbSettingsGrblLastParam
            // 
            tbSettingsGrblLastParam.DataBindings.Add(new Binding("Text", My.MySettings.Default, "GrblLastParamID", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsGrblLastParam, "tbSettingsGrblLastParam");
            tbSettingsGrblLastParam.Name = "tbSettingsGrblLastParam";
            tbSettingsGrblLastParam.Text = My.MySettings.Default.GrblLastParamID;
            ToolTip1.SetToolTip(tbSettingsGrblLastParam, resources.GetString("tbSettingsGrblLastParam.ToolTip"));
            // 
            // tbTruncationDigits
            // 
            tbTruncationDigits.DataBindings.Add(new Binding("Text", My.MySettings.Default, "TruncationDigits", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbTruncationDigits, "tbTruncationDigits");
            tbTruncationDigits.Name = "tbTruncationDigits";
            tbTruncationDigits.Text = My.MySettings.Default.TruncationDigits;
            // 
            // tbSettingsDefaultExt
            // 
            tbSettingsDefaultExt.DataBindings.Add(new Binding("Text", My.MySettings.Default, "DefaultFileExt", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsDefaultExt, "tbSettingsDefaultExt");
            tbSettingsDefaultExt.Name = "tbSettingsDefaultExt";
            tbSettingsDefaultExt.Text = My.MySettings.Default.DefaultFileExt;
            // 
            // cbSettingsLeftHanded
            // 
            resources.ApplyResources(_cbSettingsLeftHanded, "cbSettingsLeftHanded");
            _cbSettingsLeftHanded.Checked = My.MySettings.Default.LeftHandedGUI;
            _cbSettingsLeftHanded.DataBindings.Add(new Binding("Checked", My.MySettings.Default, "LeftHandedGUI", true, DataSourceUpdateMode.OnPropertyChanged));
            _cbSettingsLeftHanded.Name = "_cbSettingsLeftHanded";
            _cbSettingsLeftHanded.UseVisualStyleBackColor = true;
            // 
            // cbSettingsConnectOnLoad
            // 
            resources.ApplyResources(cbSettingsConnectOnLoad, "cbSettingsConnectOnLoad");
            cbSettingsConnectOnLoad.Checked = My.MySettings.Default.GrblConnectOnLoad;
            cbSettingsConnectOnLoad.DataBindings.Add(new Binding("Checked", My.MySettings.Default, "GrblConnectOnLoad", true, DataSourceUpdateMode.OnPropertyChanged));
            cbSettingsConnectOnLoad.Name = "cbSettingsConnectOnLoad";
            ToolTip1.SetToolTip(cbSettingsConnectOnLoad, resources.GetString("cbSettingsConnectOnLoad.ToolTip"));
            cbSettingsConnectOnLoad.UseVisualStyleBackColor = true;
            // 
            // cbSettingsPauseOnError
            // 
            resources.ApplyResources(cbSettingsPauseOnError, "cbSettingsPauseOnError");
            cbSettingsPauseOnError.Checked = My.MySettings.Default.GCodePauseOnError;
            cbSettingsPauseOnError.CheckState = CheckState.Checked;
            cbSettingsPauseOnError.DataBindings.Add(new Binding("Checked", My.MySettings.Default, "GCodePauseOnError", true, DataSourceUpdateMode.OnPropertyChanged));
            cbSettingsPauseOnError.Name = "cbSettingsPauseOnError";
            cbSettingsPauseOnError.UseVisualStyleBackColor = true;
            // 
            // cbStatusPollEnable
            // 
            resources.ApplyResources(cbStatusPollEnable, "cbStatusPollEnable");
            cbStatusPollEnable.Checked = My.MySettings.Default.StatusPollEnabled;
            cbStatusPollEnable.CheckState = CheckState.Checked;
            cbStatusPollEnable.DataBindings.Add(new Binding("Checked", My.MySettings.Default, "StatusPollEnabled", true, DataSourceUpdateMode.OnPropertyChanged));
            cbStatusPollEnable.Name = "cbStatusPollEnable";
            cbStatusPollEnable.UseVisualStyleBackColor = true;
            // 
            // tbSettingsRBuffSize
            // 
            tbSettingsRBuffSize.DataBindings.Add(new Binding("Text", My.MySettings.Default, "RBuffMaxSize", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsRBuffSize, "tbSettingsRBuffSize");
            tbSettingsRBuffSize.Name = "tbSettingsRBuffSize";
            tbSettingsRBuffSize.Text = My.MySettings.Default.RBuffMaxSize;
            // 
            // tbSettingsQSize
            // 
            tbSettingsQSize.DataBindings.Add(new Binding("Text", My.MySettings.Default, "QBuffMaxSize", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsQSize, "tbSettingsQSize");
            tbSettingsQSize.Name = "tbSettingsQSize";
            tbSettingsQSize.Text = My.MySettings.Default.QBuffMaxSize;
            // 
            // tbSettingsPollRate
            // 
            tbSettingsPollRate.DataBindings.Add(new Binding("Text", My.MySettings.Default, "statusPollInterval", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsPollRate, "tbSettingsPollRate");
            tbSettingsPollRate.Name = "tbSettingsPollRate";
            tbSettingsPollRate.Text = My.MySettings.Default.StatusPollInterval;
            // 
            // tbSettingsSpclPosition2
            // 
            tbSettingsSpclPosition2.DataBindings.Add(new Binding("Text", My.MySettings.Default, "MachineSpclPosition2", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsSpclPosition2, "tbSettingsSpclPosition2");
            tbSettingsSpclPosition2.Name = "tbSettingsSpclPosition2";
            tbSettingsSpclPosition2.Text = My.MySettings.Default.MachineSpclPosition2;
            // 
            // tbWorkZ0Cmd
            // 
            tbWorkZ0Cmd.DataBindings.Add(new Binding("Text", My.MySettings.Default, "WorkZ0Cmd", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbWorkZ0Cmd, "tbWorkZ0Cmd");
            tbWorkZ0Cmd.Name = "tbWorkZ0Cmd";
            tbWorkZ0Cmd.Text = My.MySettings.Default.WorkZ0Cmd;
            // 
            // tbWorkY0Cmd
            // 
            tbWorkY0Cmd.DataBindings.Add(new Binding("Text", My.MySettings.Default, "WorkY0Cmd", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbWorkY0Cmd, "tbWorkY0Cmd");
            tbWorkY0Cmd.Name = "tbWorkY0Cmd";
            tbWorkY0Cmd.Text = My.MySettings.Default.WorkY0Cmd;
            // 
            // tbWorkX0Cmd
            // 
            tbWorkX0Cmd.DataBindings.Add(new Binding("Text", My.MySettings.Default, "WorkX0Cmd", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbWorkX0Cmd, "tbWorkX0Cmd");
            tbWorkX0Cmd.Name = "tbWorkX0Cmd";
            tbWorkX0Cmd.Text = My.MySettings.Default.WorkX0Cmd;
            // 
            // tbSettingsZeroXYZCmd
            // 
            tbSettingsZeroXYZCmd.DataBindings.Add(new Binding("Text", My.MySettings.Default, "Work0Cmd", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsZeroXYZCmd, "tbSettingsZeroXYZCmd");
            tbSettingsZeroXYZCmd.Name = "tbSettingsZeroXYZCmd";
            tbSettingsZeroXYZCmd.Text = My.MySettings.Default.Work0Cmd;
            // 
            // tbSettingsSpclPosition1
            // 
            tbSettingsSpclPosition1.DataBindings.Add(new Binding("Text", My.MySettings.Default, "MachineSpclPosition1", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsSpclPosition1, "tbSettingsSpclPosition1");
            tbSettingsSpclPosition1.Name = "tbSettingsSpclPosition1";
            tbSettingsSpclPosition1.Text = My.MySettings.Default.MachineSpclPosition1;
            // 
            // cbSettingsKeyboardJogging
            // 
            resources.ApplyResources(cbSettingsKeyboardJogging, "cbSettingsKeyboardJogging");
            cbSettingsKeyboardJogging.Checked = My.MySettings.Default.JoggingUseKeyboard;
            cbSettingsKeyboardJogging.DataBindings.Add(new Binding("Checked", My.MySettings.Default, "JoggingUseKeyboard", true, DataSourceUpdateMode.OnPropertyChanged));
            cbSettingsKeyboardJogging.Name = "cbSettingsKeyboardJogging";
            ToolTip1.SetToolTip(cbSettingsKeyboardJogging, resources.GetString("cbSettingsKeyboardJogging.ToolTip"));
            cbSettingsKeyboardJogging.UseVisualStyleBackColor = true;
            // 
            // tbSettingsZRepeat
            // 
            tbSettingsZRepeat.DataBindings.Add(new Binding("Text", My.MySettings.Default, "JoggingZRepeat", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsZRepeat, "tbSettingsZRepeat");
            tbSettingsZRepeat.Name = "tbSettingsZRepeat";
            tbSettingsZRepeat.Text = My.MySettings.Default.JoggingZRepeat;
            // 
            // tbSettingsYRepeat
            // 
            tbSettingsYRepeat.DataBindings.Add(new Binding("Text", My.MySettings.Default, "JoggingYRepeat", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsYRepeat, "tbSettingsYRepeat");
            tbSettingsYRepeat.Name = "tbSettingsYRepeat";
            tbSettingsYRepeat.Text = My.MySettings.Default.JoggingYRepeat;
            // 
            // tbSettingsXRepeat
            // 
            tbSettingsXRepeat.DataBindings.Add(new Binding("Text", My.MySettings.Default, "JoggingXRepeat", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsXRepeat, "tbSettingsXRepeat");
            tbSettingsXRepeat.Name = "tbSettingsXRepeat";
            tbSettingsXRepeat.Text = My.MySettings.Default.JoggingXRepeat;
            // 
            // tbSettingsFRMetric
            // 
            tbSettingsFRMetric.DataBindings.Add(new Binding("Text", My.MySettings.Default, "JoggingFRMetric", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsFRMetric, "tbSettingsFRMetric");
            tbSettingsFRMetric.Name = "tbSettingsFRMetric";
            tbSettingsFRMetric.Text = My.MySettings.Default.JoggingFRMetric;
            // 
            // tbSettingsFIMetric
            // 
            tbSettingsFIMetric.DataBindings.Add(new Binding("Text", My.MySettings.Default, "JoggingFIMEtric", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsFIMetric, "tbSettingsFIMetric");
            tbSettingsFIMetric.Name = "tbSettingsFIMetric";
            tbSettingsFIMetric.Text = My.MySettings.Default.JoggingFIMEtric;
            // 
            // tbSettingsFRImperial
            // 
            tbSettingsFRImperial.DataBindings.Add(new Binding("Text", My.MySettings.Default, "JoggingFRImperial", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsFRImperial, "tbSettingsFRImperial");
            tbSettingsFRImperial.Name = "tbSettingsFRImperial";
            tbSettingsFRImperial.Text = My.MySettings.Default.JoggingFRImperial;
            // 
            // cbSettingsMetric
            // 
            resources.ApplyResources(_cbSettingsMetric, "cbSettingsMetric");
            _cbSettingsMetric.Checked = My.MySettings.Default.JoggingUnitsMetric;
            _cbSettingsMetric.DataBindings.Add(new Binding("Checked", My.MySettings.Default, "joggingUnitsMetric", true, DataSourceUpdateMode.OnPropertyChanged));
            _cbSettingsMetric.Name = "_cbSettingsMetric";
            _cbSettingsMetric.UseVisualStyleBackColor = true;
            // 
            // tbSettingsFIImperial
            // 
            tbSettingsFIImperial.DataBindings.Add(new Binding("Text", My.MySettings.Default, "JoggingFIImperial", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(tbSettingsFIImperial, "tbSettingsFIImperial");
            tbSettingsFIImperial.Name = "tbSettingsFIImperial";
            tbSettingsFIImperial.Text = My.MySettings.Default.JoggingFIImperial;
            // 
            // GrblGui
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabControl1);
            Controls.Add(MenuStrip1);
            KeyPreview = true;
            MainMenuStrip = MenuStrip1;
            Name = "GrblGui";
            SizeGripStyle = SizeGripStyle.Hide;
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            TabControl1.ResumeLayout(false);
            tabPgInterface.ResumeLayout(false);
            gbOverrides.ResumeLayout(false);
            gbOverrides.PerformLayout();
            gbState.ResumeLayout(false);
            gbPinStatus.ResumeLayout(false);
            gbPinStatus.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            gbControl.ResumeLayout(false);
            gbControl.PerformLayout();
            gbMDI.ResumeLayout(false);
            gbMDI.PerformLayout();
            gbJogging.ResumeLayout(false);
            gbJogging.PerformLayout();
            gbFeedRate.ResumeLayout(false);
            gbFeedRate.PerformLayout();
            gbDistance.ResumeLayout(false);
            gbDistance.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            gbGcode.ResumeLayout(false);
            gbGcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvGcode).EndInit();
            gbGrbl.ResumeLayout(false);
            tcConnection.ResumeLayout(false);
            tbGrblCOM.ResumeLayout(false);
            tbGrblIP.ResumeLayout(false);
            tbGrblIP.PerformLayout();
            gbPosition.ResumeLayout(false);
            tabCtlPosition.ResumeLayout(false);
            tpWork.ResumeLayout(false);
            tpWork.PerformLayout();
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            tpOffsets.ResumeLayout(false);
            tpOffsets.PerformLayout();
            tabPgSettings.ResumeLayout(false);
            tabPgSettings.PerformLayout();
            gbMiscInfo.ResumeLayout(false);
            gbMiscInfo.PerformLayout();
            gbGrblSettings.ResumeLayout(false);
            gbGrblSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgGrblSettings).EndInit();
            gbSettingsOffsets.ResumeLayout(false);
            gbSettingsOffsets.PerformLayout();
            gbSettingsMisc.ResumeLayout(false);
            gbSettingsMisc.PerformLayout();
            gbSettingsPosition.ResumeLayout(false);
            gbSettingsPosition.PerformLayout();
            gbSettingsJogging.ResumeLayout(false);
            gbSettingsJogging.PerformLayout();
            TabPage1.ResumeLayout(false);
            gbEditor.ResumeLayout(false);
            gbEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgMacros).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrblSettingsBindingSource).EndInit();
            Load += new EventHandler(grblgui_Load);
            FormClosing += new FormClosingEventHandler(grblgui_unload);
            FormClosing += new FormClosingEventHandler(GrblMacroButtons_FormClosing);
            Load += new EventHandler(GrblMacroButtons_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem ToolStripMenuItem1;
        internal ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem _ExitToolStripMenuItem;

        internal ToolStripMenuItem ExitToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExitToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExitToolStripMenuItem != null)
                {
                    _ExitToolStripMenuItem.Click -= ExitToolStripMenuItem_Click;
                }

                _ExitToolStripMenuItem = value;
                if (_ExitToolStripMenuItem != null)
                {
                    _ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem ToolsToolStripMenuItem;
        private ToolStripMenuItem _OptionsToolStripMenuItem;

        internal ToolStripMenuItem OptionsToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OptionsToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OptionsToolStripMenuItem != null)
                {
                    _OptionsToolStripMenuItem.Click -= OptionsToolStripMenuItem_Click;
                }

                _OptionsToolStripMenuItem = value;
                if (_OptionsToolStripMenuItem != null)
                {
                    _OptionsToolStripMenuItem.Click += OptionsToolStripMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem HelpToolStripMenuItem;
        private ToolStripMenuItem _AboutToolStripMenuItem;

        internal ToolStripMenuItem AboutToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AboutToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AboutToolStripMenuItem != null)
                {
                    _AboutToolStripMenuItem.Click -= AboutToolStripMenuItem_Click;
                }

                _AboutToolStripMenuItem = value;
                if (_AboutToolStripMenuItem != null)
                {
                    _AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
                }
            }
        }

        internal TabControl TabControl1;
        internal TabPage tabPgInterface;
        internal GroupBox gbJogging;
        private RadioButton _rbFeedRate4;

        internal RadioButton rbFeedRate4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbFeedRate4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbFeedRate4 != null)
                {
                    _rbFeedRate4.CheckedChanged -= rbDistancex_CheckedChanged;
                }

                _rbFeedRate4 = value;
                if (_rbFeedRate4 != null)
                {
                    _rbFeedRate4.CheckedChanged += rbDistancex_CheckedChanged;
                }
            }
        }

        private RadioButton _rbFeedRate3;

        internal RadioButton rbFeedRate3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbFeedRate3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbFeedRate3 != null)
                {
                    _rbFeedRate3.CheckedChanged -= rbDistancex_CheckedChanged;
                }

                _rbFeedRate3 = value;
                if (_rbFeedRate3 != null)
                {
                    _rbFeedRate3.CheckedChanged += rbDistancex_CheckedChanged;
                }
            }
        }

        private RadioButton _rbFeedRate1;

        internal RadioButton rbFeedRate1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbFeedRate1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbFeedRate1 != null)
                {
                    _rbFeedRate1.CheckedChanged -= rbDistancex_CheckedChanged;
                }

                _rbFeedRate1 = value;
                if (_rbFeedRate1 != null)
                {
                    _rbFeedRate1.CheckedChanged += rbDistancex_CheckedChanged;
                }
            }
        }

        private RadioButton _rbFeedRate2;

        internal RadioButton rbFeedRate2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbFeedRate2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbFeedRate2 != null)
                {
                    _rbFeedRate2.CheckedChanged -= rbDistancex_CheckedChanged;
                }

                _rbFeedRate2 = value;
                if (_rbFeedRate2 != null)
                {
                    _rbFeedRate2.CheckedChanged += rbDistancex_CheckedChanged;
                }
            }
        }

        private RadioButton _rbDistance4;

        internal RadioButton rbDistance4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbDistance4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbDistance4 != null)
                {
                    _rbDistance4.CheckedChanged -= rbDistancex_CheckedChanged;
                }

                _rbDistance4 = value;
                if (_rbDistance4 != null)
                {
                    _rbDistance4.CheckedChanged += rbDistancex_CheckedChanged;
                }
            }
        }

        private RadioButton _rbDistance3;

        internal RadioButton rbDistance3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbDistance3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbDistance3 != null)
                {
                    _rbDistance3.CheckedChanged -= rbDistancex_CheckedChanged;
                }

                _rbDistance3 = value;
                if (_rbDistance3 != null)
                {
                    _rbDistance3.CheckedChanged += rbDistancex_CheckedChanged;
                }
            }
        }

        private RadioButton _rbDistance2;

        internal RadioButton rbDistance2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbDistance2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbDistance2 != null)
                {
                    _rbDistance2.CheckedChanged -= rbDistancex_CheckedChanged;
                }

                _rbDistance2 = value;
                if (_rbDistance2 != null)
                {
                    _rbDistance2.CheckedChanged += rbDistancex_CheckedChanged;
                }
            }
        }

        private RadioButton _rbDistance1;

        internal RadioButton rbDistance1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbDistance1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbDistance1 != null)
                {
                    _rbDistance1.CheckedChanged -= rbDistancex_CheckedChanged;
                }

                _rbDistance1 = value;
                if (_rbDistance1 != null)
                {
                    _rbDistance1.CheckedChanged += rbDistancex_CheckedChanged;
                }
            }
        }

        internal TabPage tabPgSettings;
        internal GroupBox gbPosition;
        internal GroupBox gbGrbl;
        private Button _btnConnect;

        internal Button btnConnect
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnConnect;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnConnect != null)
                {
                    _btnConnect.Click -= btnConnDisconnect_Click;
                }

                _btnConnect = value;
                if (_btnConnect != null)
                {
                    _btnConnect.Click += btnConnDisconnect_Click;
                }
            }
        }

        private ComboBox _cbPorts;

        internal ComboBox cbPorts
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbPorts;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbPorts != null)
                {
                    _cbPorts.SelectedIndexChanged -= lbPorts_SelectedIndexChanged;
                }

                _cbPorts = value;
                if (_cbPorts != null)
                {
                    _cbPorts.SelectedIndexChanged += lbPorts_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cbBaud;

        internal ComboBox cbBaud
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbBaud;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbBaud != null)
                {
                    _cbBaud.SelectedIndexChanged -= cbBaud_SelectedIndexChanged;
                }

                _cbBaud = value;
                if (_cbBaud != null)
                {
                    _cbBaud.SelectedIndexChanged += cbBaud_SelectedIndexChanged;
                }
            }
        }

        internal ListBox lbResponses;
        private Button _btnSend;

        internal Button btnSend
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSend;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSend != null)
                {
                    _btnSend.Click -= btnSend_Click;
                }

                _btnSend = value;
                if (_btnSend != null)
                {
                    _btnSend.Click += btnSend_Click;
                }
            }
        }

        private TextBox _tbSendData;

        internal TextBox tbSendData
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbSendData;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSendData != null)
                {
                    _tbSendData.KeyDown -= tbSendData_KeyDown;
                }

                _tbSendData = value;
                if (_tbSendData != null)
                {
                    _tbSendData.KeyDown += tbSendData_KeyDown;
                }
            }
        }

        internal TextBox tbMachX;
        internal TextBox tbMachY;
        internal TextBox tbMachZ;
        private TextBox _tbWorkZ;

        internal TextBox tbWorkZ
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbWorkZ;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbWorkZ != null)
                {
                    _tbWorkZ.Click -= tbWork_Click;
                }

                _tbWorkZ = value;
                if (_tbWorkZ != null)
                {
                    _tbWorkZ.Click += tbWork_Click;
                }
            }
        }

        private TextBox _tbWorkY;

        internal TextBox tbWorkY
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbWorkY;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbWorkY != null)
                {
                    _tbWorkY.Click -= tbWork_Click;
                }

                _tbWorkY = value;
                if (_tbWorkY != null)
                {
                    _tbWorkY.Click += tbWork_Click;
                }
            }
        }

        private Button _btnWorkZ0;

        internal Button btnWorkZ0
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnWorkZ0;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnWorkZ0 != null)
                {
                    _btnWorkZ0.Click -= btnWorkXYZ0_Click;
                }

                _btnWorkZ0 = value;
                if (_btnWorkZ0 != null)
                {
                    _btnWorkZ0.Click += btnWorkXYZ0_Click;
                }
            }
        }

        private Button _btnWorkY0;

        internal Button btnWorkY0
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnWorkY0;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnWorkY0 != null)
                {
                    _btnWorkY0.Click -= btnWorkXYZ0_Click;
                }

                _btnWorkY0 = value;
                if (_btnWorkY0 != null)
                {
                    _btnWorkY0.Click += btnWorkXYZ0_Click;
                }
            }
        }

        private Button _btnWorkX0;

        internal Button btnWorkX0
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnWorkX0;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnWorkX0 != null)
                {
                    _btnWorkX0.Click -= btnWorkXYZ0_Click;
                }

                _btnWorkX0 = value;
                if (_btnWorkX0 != null)
                {
                    _btnWorkX0.Click += btnWorkXYZ0_Click;
                }
            }
        }

        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        private Button _btnHome;

        internal Button btnHome
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnHome;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnHome != null)
                {
                    _btnHome.Click -= btnPosition_Click;
                }

                _btnHome = value;
                if (_btnHome != null)
                {
                    _btnHome.Click += btnPosition_Click;
                }
            }
        }

        private Button _btnWork0;

        internal Button btnWork0
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnWork0;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnWork0 != null)
                {
                    _btnWork0.Click -= btnPosition_Click;
                }

                _btnWork0 = value;
                if (_btnWork0 != null)
                {
                    _btnWork0.Click += btnPosition_Click;
                }
            }
        }

        private Button _btnReset;

        public Button btnReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnReset != null)
                {
                    _btnReset.Click -= btnReset_Click;
                }

                _btnReset = value;
                if (_btnReset != null)
                {
                    _btnReset.Click += btnReset_Click;
                }
            }
        }

        internal CheckBox cbVerbose;
        private CheckBox _cbUnits;

        internal CheckBox cbUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbUnits != null)
                {
                    _cbUnits.CheckedChanged -= cbUnits_CheckedChanged;
                }

                _cbUnits = value;
                if (_cbUnits != null)
                {
                    _cbUnits.CheckedChanged += cbUnits_CheckedChanged;
                }
            }
        }

        internal GroupBox gbFeedRate;
        internal GroupBox gbDistance;
        internal GroupBox gbSettingsJogging;
        private CheckBox _cbSettingsMetric;

        internal CheckBox cbSettingsMetric
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbSettingsMetric;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbSettingsMetric != null)
                {
                    _cbSettingsMetric.CheckedChanged -= cbSettingsMetric_CheckedChanged;
                }

                _cbSettingsMetric = value;
                if (_cbSettingsMetric != null)
                {
                    _cbSettingsMetric.CheckedChanged += cbSettingsMetric_CheckedChanged;
                }
            }
        }

        private Button _btnFileSend;

        internal Button btnFileSend
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFileSend;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFileSend != null)
                {
                    _btnFileSend.MouseHover -= btnFileSend_MouseHover;
                    _btnFileSend.Click -= btnFileGroup_Click;
                }

                _btnFileSend = value;
                if (_btnFileSend != null)
                {
                    _btnFileSend.MouseHover += btnFileSend_MouseHover;
                    _btnFileSend.Click += btnFileGroup_Click;
                }
            }
        }

        private Button _btnFileSelect;

        internal Button btnFileSelect
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFileSelect;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFileSelect != null)
                {
                    _btnFileSelect.Click -= btnFileGroup_Click;
                }

                _btnFileSelect = value;
                if (_btnFileSelect != null)
                {
                    _btnFileSelect.Click += btnFileGroup_Click;
                }
            }
        }

        private Button _btnFilePause;

        internal Button btnFilePause
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFilePause;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFilePause != null)
                {
                    _btnFilePause.Click -= btnFileGroup_Click;
                }

                _btnFilePause = value;
                if (_btnFilePause != null)
                {
                    _btnFilePause.Click += btnFileGroup_Click;
                }
            }
        }

        private Button _btnFileStop;

        internal Button btnFileStop
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFileStop;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFileStop != null)
                {
                    _btnFileStop.Click -= btnFileGroup_Click;
                }

                _btnFileStop = value;
                if (_btnFileStop != null)
                {
                    _btnFileStop.Click += btnFileGroup_Click;
                }
            }
        }

        private OpenFileDialog ofdGcodeFile;
        internal TextBox tbGcodeFile;
        internal Label Label9;
        internal GroupBox gbSettingsPosition;
        internal Label Label13;
        internal Label Label12;
        internal TextBox tbWorkX0Cmd;
        internal TextBox tbSettingsZeroXYZCmd;
        internal Label Label11;
        internal TextBox tbSettingsSpclPosition1;
        private Button _btnUnlock;

        public Button btnUnlock
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUnlock;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUnlock != null)
                {
                    _btnUnlock.Click -= btnUnlock_Click;
                }

                _btnUnlock = value;
                if (_btnUnlock != null)
                {
                    _btnUnlock.Click += btnUnlock_Click;
                }
            }
        }

        internal GroupBox gbGcode;
        internal Label lblTotalLines;
        internal CheckBox cbStatusPollEnable;
        internal ProgressBar prgBarQ;
        internal Label Label25;
        internal Label Label24;
        internal ProgressBar prgbRxBuf;
        internal GroupBox gbSettingsMisc;
        internal Label Label26;
        internal TextBox tbSettingsPollRate;
        internal TextBox tbGCodeMessage;
        internal Label Label27;
        internal Label Label29;
        internal TextBox tbWorkZ0Cmd;
        internal Label Label28;
        internal TextBox tbWorkY0Cmd;
        private Button _btnHold;

        public Button btnHold
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnHold;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnHold != null)
                {
                    _btnHold.Click -= btnHold_Click;
                }

                _btnHold = value;
                if (_btnHold != null)
                {
                    _btnHold.Click += btnHold_Click;
                }
            }
        }

        private Button _btnStartResume;

        public Button btnStartResume
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnStartResume;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnStartResume != null)
                {
                    _btnStartResume.Click -= btnStartResume_Click;
                }

                _btnStartResume = value;
                if (_btnStartResume != null)
                {
                    _btnStartResume.Click += btnStartResume_Click;
                }
            }
        }

        private Button _btnRescanPorts;

        internal Button btnRescanPorts
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRescanPorts;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRescanPorts != null)
                {
                    _btnRescanPorts.Click -= btnRescanPorts_Click;
                }

                _btnRescanPorts = value;
                if (_btnRescanPorts != null)
                {
                    _btnRescanPorts.Click += btnRescanPorts_Click;
                }
            }
        }

        internal Label Label35;
        internal Label Label34;
        internal Label Label32;
        internal TextBox tbSettingsFRMetric;
        internal Label Label33;
        internal TextBox tbSettingsFIMetric;
        internal Label Label31;
        internal TextBox tbSettingsFRImperial;
        internal Label Label30;
        internal TextBox tbSettingsFIImperial;
        internal Label Label37;
        internal Label Label36;
        internal TextBox tbSettingsRBuffSize;
        internal TextBox tbSettingsQSize;
        internal Label Label40;
        internal Label Label39;
        internal Label Label38;
        internal TextBox tbSettingsZRepeat;
        internal TextBox tbSettingsYRepeat;
        internal TextBox tbSettingsXRepeat;
        internal Label Label41;
        private Button _btnSettingsRefreshMisc;

        internal Button btnSettingsRefreshMisc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSettingsRefreshMisc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSettingsRefreshMisc != null)
                {
                    _btnSettingsRefreshMisc.Click -= btnSettingsRefreshMisc_Click;
                }

                _btnSettingsRefreshMisc = value;
                if (_btnSettingsRefreshMisc != null)
                {
                    _btnSettingsRefreshMisc.Click += btnSettingsRefreshMisc_Click;
                }
            }
        }

        private Button _btnSettingsRefreshPosition;

        internal Button btnSettingsRefreshPosition
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSettingsRefreshPosition;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSettingsRefreshPosition != null)
                {
                    _btnSettingsRefreshPosition.Click -= btnSettingsRefreshMisc_Click;
                }

                _btnSettingsRefreshPosition = value;
                if (_btnSettingsRefreshPosition != null)
                {
                    _btnSettingsRefreshPosition.Click += btnSettingsRefreshMisc_Click;
                }
            }
        }

        private Button _btnSettingsRefreshJogging;

        internal Button btnSettingsRefreshJogging
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSettingsRefreshJogging;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSettingsRefreshJogging != null)
                {
                    _btnSettingsRefreshJogging.Click -= btnSettingsRefreshMisc_Click;
                }

                _btnSettingsRefreshJogging = value;
                if (_btnSettingsRefreshJogging != null)
                {
                    _btnSettingsRefreshJogging.Click += btnSettingsRefreshMisc_Click;
                }
            }
        }

        internal Label Label42;
        internal CheckBox cbSettingsPauseOnError;
        internal ToolTip ToolTip1;
        private Button _btnSettingsGrbl;

        internal Button btnSettingsGrbl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSettingsGrbl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSettingsGrbl != null)
                {
                    _btnSettingsGrbl.Click -= btnSettingsGrbl_Click;
                }

                _btnSettingsGrbl = value;
                if (_btnSettingsGrbl != null)
                {
                    _btnSettingsGrbl.Click += btnSettingsGrbl_Click;
                }
            }
        }

        private DataGridView _dgGrblSettings;

        internal DataGridView dgGrblSettings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgGrblSettings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgGrblSettings != null)
                {
                    _dgGrblSettings.CellMouseDoubleClick -= dgGrblSettings_CellMouseDoubleClick;
                }

                _dgGrblSettings = value;
                if (_dgGrblSettings != null)
                {
                    _dgGrblSettings.CellMouseDoubleClick += dgGrblSettings_CellMouseDoubleClick;
                }
            }
        }

        private Button _btnOffsetsSave;

        internal Button btnOffsetsSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsSave != null)
                {
                    _btnOffsetsSave.Click -= btnOffsetsSave_Click;
                }

                _btnOffsetsSave = value;
                if (_btnOffsetsSave != null)
                {
                    _btnOffsetsSave.Click += btnOffsetsSave_Click;
                }
            }
        }

        private Button _btnOffsetsRetrieve;

        internal Button btnOffsetsRetrieve
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsRetrieve;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsRetrieve != null)
                {
                    _btnOffsetsRetrieve.Click -= btnOffsetsRetrieve_Click;
                }

                _btnOffsetsRetrieve = value;
                if (_btnOffsetsRetrieve != null)
                {
                    _btnOffsetsRetrieve.Click += btnOffsetsRetrieve_Click;
                }
            }
        }

        private Button _btnOffsetsLoad;

        internal Button btnOffsetsLoad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsLoad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsLoad != null)
                {
                    _btnOffsetsLoad.Click -= btnOffsetsLoad_Click;
                }

                _btnOffsetsLoad = value;
                if (_btnOffsetsLoad != null)
                {
                    _btnOffsetsLoad.Click += btnOffsetsLoad_Click;
                }
            }
        }

        private Button _btnOffsetsG43Zero;

        internal Button btnOffsetsG43Zero
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG43Zero;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG43Zero != null)
                {
                    _btnOffsetsG43Zero.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG43Zero = value;
                if (_btnOffsetsG43Zero != null)
                {
                    _btnOffsetsG43Zero.Click += btnOffsetsZero_Click;
                }
            }
        }

        private TextBox _tbOffsetsG43Z;

        internal TextBox tbOffsetsG43Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG43Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG43Z != null)
                {
                    _tbOffsetsG43Z.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG43Z = value;
                if (_tbOffsetsG43Z != null)
                {
                    _tbOffsetsG43Z.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        internal Label Label18;
        internal Label Label19;
        internal Label Label20;
        private Button _btnOffsetsG30Set;

        internal Button btnOffsetsG30Set
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG30Set;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG30Set != null)
                {
                    _btnOffsetsG30Set.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG30Set = value;
                if (_btnOffsetsG30Set != null)
                {
                    _btnOffsetsG30Set.Click += btnOffsetsZero_Click;
                }
            }
        }

        internal TextBox tbOffsetsG30Z;
        internal TextBox tbOffsetsG30Y;
        internal TextBox tbOffsetsG30X;
        internal TextBox tbOffsetsG28Z;
        internal TextBox tbOffsetsG28Y;
        internal TextBox tbOffsetsG28X;
        internal Label Label21;
        internal Label Label43;
        internal Label Label60;
        private Button _btnOffsetsG55Zero;

        internal Button btnOffsetsG55Zero
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG55Zero;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG55Zero != null)
                {
                    _btnOffsetsG55Zero.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG55Zero = value;
                if (_btnOffsetsG55Zero != null)
                {
                    _btnOffsetsG55Zero.Click += btnOffsetsZero_Click;
                }
            }
        }

        private TextBox _tbOffsetsG55Z;

        internal TextBox tbOffsetsG55Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG55Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG55Z != null)
                {
                    _tbOffsetsG55Z.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG55Z = value;
                if (_tbOffsetsG55Z != null)
                {
                    _tbOffsetsG55Z.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG55Y;

        internal TextBox tbOffsetsG55Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG55Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG55Y != null)
                {
                    _tbOffsetsG55Y.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG55Y = value;
                if (_tbOffsetsG55Y != null)
                {
                    _tbOffsetsG55Y.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG55X;

        internal TextBox tbOffsetsG55X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG55X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG55X != null)
                {
                    _tbOffsetsG55X.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG55X = value;
                if (_tbOffsetsG55X != null)
                {
                    _tbOffsetsG55X.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private Button _btnOffsetsG56Zero;

        internal Button btnOffsetsG56Zero
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG56Zero;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG56Zero != null)
                {
                    _btnOffsetsG56Zero.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG56Zero = value;
                if (_btnOffsetsG56Zero != null)
                {
                    _btnOffsetsG56Zero.Click += btnOffsetsZero_Click;
                }
            }
        }

        private TextBox _tbOffsetsG56Z;

        internal TextBox tbOffsetsG56Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG56Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG56Z != null)
                {
                    _tbOffsetsG56Z.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG56Z = value;
                if (_tbOffsetsG56Z != null)
                {
                    _tbOffsetsG56Z.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG56Y;

        internal TextBox tbOffsetsG56Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG56Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG56Y != null)
                {
                    _tbOffsetsG56Y.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG56Y = value;
                if (_tbOffsetsG56Y != null)
                {
                    _tbOffsetsG56Y.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG56X;

        internal TextBox tbOffsetsG56X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG56X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG56X != null)
                {
                    _tbOffsetsG56X.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG56X = value;
                if (_tbOffsetsG56X != null)
                {
                    _tbOffsetsG56X.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private Button _btnOffsetsG57Zero;

        internal Button btnOffsetsG57Zero
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG57Zero;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG57Zero != null)
                {
                    _btnOffsetsG57Zero.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG57Zero = value;
                if (_btnOffsetsG57Zero != null)
                {
                    _btnOffsetsG57Zero.Click += btnOffsetsZero_Click;
                }
            }
        }

        private TextBox _tbOffsetsG57Z;

        internal TextBox tbOffsetsG57Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG57Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG57Z != null)
                {
                    _tbOffsetsG57Z.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG57Z = value;
                if (_tbOffsetsG57Z != null)
                {
                    _tbOffsetsG57Z.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG57Y;

        internal TextBox tbOffsetsG57Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG57Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG57Y != null)
                {
                    _tbOffsetsG57Y.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG57Y = value;
                if (_tbOffsetsG57Y != null)
                {
                    _tbOffsetsG57Y.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG57X;

        internal TextBox tbOffsetsG57X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG57X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG57X != null)
                {
                    _tbOffsetsG57X.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG57X = value;
                if (_tbOffsetsG57X != null)
                {
                    _tbOffsetsG57X.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private Button _btnOffsetsG58Zero;

        internal Button btnOffsetsG58Zero
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG58Zero;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG58Zero != null)
                {
                    _btnOffsetsG58Zero.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG58Zero = value;
                if (_btnOffsetsG58Zero != null)
                {
                    _btnOffsetsG58Zero.Click += btnOffsetsZero_Click;
                }
            }
        }

        private TextBox _tbOffsetsG58Z;

        internal TextBox tbOffsetsG58Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG58Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG58Z != null)
                {
                    _tbOffsetsG58Z.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG58Z = value;
                if (_tbOffsetsG58Z != null)
                {
                    _tbOffsetsG58Z.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG58Y;

        internal TextBox tbOffsetsG58Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG58Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG58Y != null)
                {
                    _tbOffsetsG58Y.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG58Y = value;
                if (_tbOffsetsG58Y != null)
                {
                    _tbOffsetsG58Y.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG58X;

        internal TextBox tbOffsetsG58X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG58X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG58X != null)
                {
                    _tbOffsetsG58X.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG58X = value;
                if (_tbOffsetsG58X != null)
                {
                    _tbOffsetsG58X.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private Button _btnOffsetsG59Zero;

        internal Button btnOffsetsG59Zero
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG59Zero;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG59Zero != null)
                {
                    _btnOffsetsG59Zero.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG59Zero = value;
                if (_btnOffsetsG59Zero != null)
                {
                    _btnOffsetsG59Zero.Click += btnOffsetsZero_Click;
                }
            }
        }

        private TextBox _tbOffsetsG59Z;

        internal TextBox tbOffsetsG59Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG59Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG59Z != null)
                {
                    _tbOffsetsG59Z.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG59Z = value;
                if (_tbOffsetsG59Z != null)
                {
                    _tbOffsetsG59Z.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG59Y;

        internal TextBox tbOffsetsG59Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG59Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG59Y != null)
                {
                    _tbOffsetsG59Y.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG59Y = value;
                if (_tbOffsetsG59Y != null)
                {
                    _tbOffsetsG59Y.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG59X;

        internal TextBox tbOffsetsG59X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG59X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG59X != null)
                {
                    _tbOffsetsG59X.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG59X = value;
                if (_tbOffsetsG59X != null)
                {
                    _tbOffsetsG59X.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private Button _btnOffsetsG54Zero;

        internal Button btnOffsetsG54Zero
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG54Zero;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG54Zero != null)
                {
                    _btnOffsetsG54Zero.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG54Zero = value;
                if (_btnOffsetsG54Zero != null)
                {
                    _btnOffsetsG54Zero.Click += btnOffsetsZero_Click;
                }
            }
        }

        private TextBox _tbOffsetsG54Z;

        internal TextBox tbOffsetsG54Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG54Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG54Z != null)
                {
                    _tbOffsetsG54Z.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG54Z = value;
                if (_tbOffsetsG54Z != null)
                {
                    _tbOffsetsG54Z.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG54Y;

        internal TextBox tbOffsetsG54Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG54Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG54Y != null)
                {
                    _tbOffsetsG54Y.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG54Y = value;
                if (_tbOffsetsG54Y != null)
                {
                    _tbOffsetsG54Y.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        private TextBox _tbOffsetsG54X;

        internal TextBox tbOffsetsG54X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbOffsetsG54X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbOffsetsG54X != null)
                {
                    _tbOffsetsG54X.DoubleClick -= tbOffsets_DoubleClick;
                }

                _tbOffsetsG54X = value;
                if (_tbOffsetsG54X != null)
                {
                    _tbOffsetsG54X.DoubleClick += tbOffsets_DoubleClick;
                }
            }
        }

        internal Label Label69;
        internal Label Label68;
        internal TextBox tbOffSetsMachZ;
        internal TextBox tbOffSetsMachY;
        internal TextBox tbOffSetsMachX;
        internal SaveFileDialog sfdOffsets;
        internal OpenFileDialog ofdOffsets;
        internal TabControl tabCtlPosition;
        internal TabPage tpWork;
        internal TabPage tpOffsets;
        internal GroupBox gbMDI;
        internal GroupBox gbControl;
        internal TextBox tbCurrentStatus;
        private RepeatButton.RepeatButton _btnZMinus;

        internal RepeatButton.RepeatButton btnZMinus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnZMinus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnZMinus != null)
                {
                    _btnZMinus.Click -= btnJogArray_Click;
                }

                _btnZMinus = value;
                if (_btnZMinus != null)
                {
                    _btnZMinus.Click += btnJogArray_Click;
                }
            }
        }

        private RepeatButton.RepeatButton _btnZPlus;

        internal RepeatButton.RepeatButton btnZPlus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnZPlus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnZPlus != null)
                {
                    _btnZPlus.Click -= btnJogArray_Click;
                }

                _btnZPlus = value;
                if (_btnZPlus != null)
                {
                    _btnZPlus.Click += btnJogArray_Click;
                }
            }
        }

        private RepeatButton.RepeatButton _btnXPlus;

        internal RepeatButton.RepeatButton btnXPlus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnXPlus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnXPlus != null)
                {
                    _btnXPlus.Click -= btnJogArray_Click;
                }

                _btnXPlus = value;
                if (_btnXPlus != null)
                {
                    _btnXPlus.Click += btnJogArray_Click;
                }
            }
        }

        private RepeatButton.RepeatButton _btnYMinus;

        internal RepeatButton.RepeatButton btnYMinus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnYMinus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnYMinus != null)
                {
                    _btnYMinus.Click -= btnJogArray_Click;
                }

                _btnYMinus = value;
                if (_btnYMinus != null)
                {
                    _btnYMinus.Click += btnJogArray_Click;
                }
            }
        }

        private RepeatButton.RepeatButton _btnXMinus;

        internal RepeatButton.RepeatButton btnXMinus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnXMinus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnXMinus != null)
                {
                    _btnXMinus.Click -= btnJogArray_Click;
                }

                _btnXMinus = value;
                if (_btnXMinus != null)
                {
                    _btnXMinus.Click += btnJogArray_Click;
                }
            }
        }

        private RepeatButton.RepeatButton _btnYPlus;

        internal RepeatButton.RepeatButton btnYPlus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnYPlus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnYPlus != null)
                {
                    _btnYPlus.Click -= btnJogArray_Click;
                }

                _btnYPlus = value;
                if (_btnYPlus != null)
                {
                    _btnYPlus.Click += btnJogArray_Click;
                }
            }
        }

        internal Label Label71;
        internal CheckBox cbSettingsConnectOnLoad;
        private Button _btnStatusClearPins;

        internal Button btnStatusClearPins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnStatusClearPins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnStatusClearPins != null)
                {
                    _btnStatusClearPins.Click -= btnStatusClearPins_Click;
                }

                _btnStatusClearPins = value;
                if (_btnStatusClearPins != null)
                {
                    _btnStatusClearPins.Click += btnStatusClearPins_Click;
                }
            }
        }

        internal GroupBox gbSettingsOffsets;
        internal Label Label7;
        private TextBox _tbWorkX;

        internal TextBox tbWorkX
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbWorkX;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbWorkX != null)
                {
                    _tbWorkX.DoubleClick -= tbWorkX_TextChanged;
                    _tbWorkX.Click -= tbWork_Click;
                }

                _tbWorkX = value;
                if (_tbWorkX != null)
                {
                    _tbWorkX.DoubleClick += tbWorkX_TextChanged;
                    _tbWorkX.Click += tbWork_Click;
                }
            }
        }

        internal Label Label8;
        internal TextBox tbSettingsSpclPosition2;
        internal CheckBox cbSettingsKeyboardJogging;
        private Button _btnCheckMode;

        public Button btnCheckMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCheckMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCheckMode != null)
                {
                    _btnCheckMode.Click -= btnCheckMode_Click;
                }

                _btnCheckMode = value;
                if (_btnCheckMode != null)
                {
                    _btnCheckMode.Click += btnCheckMode_Click;
                }
            }
        }

        private Button _btnSettingsRetrieveLocations;

        internal Button btnSettingsRetrieveLocations
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSettingsRetrieveLocations;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSettingsRetrieveLocations != null)
                {
                    _btnSettingsRetrieveLocations.Click -= btnOffsetsRetrieve_Click;
                }

                _btnSettingsRetrieveLocations = value;
                if (_btnSettingsRetrieveLocations != null)
                {
                    _btnSettingsRetrieveLocations.Click += btnOffsetsRetrieve_Click;
                }
            }
        }

        internal Label Label10;
        private CheckBox _cbSettingsLeftHanded;

        internal CheckBox cbSettingsLeftHanded
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbSettingsLeftHanded;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbSettingsLeftHanded != null)
                {
                    _cbSettingsLeftHanded.CheckedChanged -= cbSettingsLeftHanded_CheckedChanged;
                }

                _cbSettingsLeftHanded = value;
                if (_cbSettingsLeftHanded != null)
                {
                    _cbSettingsLeftHanded.CheckedChanged += cbSettingsLeftHanded_CheckedChanged;
                }
            }
        }

        private Button _btnWorkSoftHome;

        private Button btnWorkSoftHome
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnWorkSoftHome;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnWorkSoftHome != null)
                {
                    _btnWorkSoftHome.Click -= btnPosition_Click;
                }

                _btnWorkSoftHome = value;
                if (_btnWorkSoftHome != null)
                {
                    _btnWorkSoftHome.Click += btnPosition_Click;
                }
            }
        }

        private Button _btnWorkSpclPosition;

        internal Button btnWorkSpclPosition
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnWorkSpclPosition;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnWorkSpclPosition != null)
                {
                    _btnWorkSpclPosition.Click -= btnPosition_Click;
                }

                _btnWorkSpclPosition = value;
                if (_btnWorkSpclPosition != null)
                {
                    _btnWorkSpclPosition.Click += btnPosition_Click;
                }
            }
        }

        internal GroupBox gbState;
        internal Label Label123;
        internal Label Lalbel49;
        internal Label Label47;
        internal Label Label45;
        internal Label Label17;
        internal Label Label15;
        internal Label Label53;
        internal Label Label50;
        internal Label Label14;
        internal Label Label16;
        private ComboBox _cbxStateUnits;

        internal ComboBox cbxStateUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxStateUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxStateUnits != null)
                {
                    _cbxStateUnits.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
                }

                _cbxStateUnits = value;
                if (_cbxStateUnits != null)
                {
                    _cbxStateUnits.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
                }
            }
        }

        private ComboBox _cbxStateDistance;

        internal ComboBox cbxStateDistance
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxStateDistance;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxStateDistance != null)
                {
                    _cbxStateDistance.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
                }

                _cbxStateDistance = value;
                if (_cbxStateDistance != null)
                {
                    _cbxStateDistance.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
                }
            }
        }

        internal TextBox tbStateFeedRate;
        private ComboBox _cbxStateFeedMode;

        internal ComboBox cbxStateFeedMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxStateFeedMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxStateFeedMode != null)
                {
                    _cbxStateFeedMode.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
                }

                _cbxStateFeedMode = value;
                if (_cbxStateFeedMode != null)
                {
                    _cbxStateFeedMode.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
                }
            }
        }

        internal TextBox tbStateTool;
        internal TextBox tbStateSpindleRPM;
        private ComboBox _cbxStatePlane;

        internal ComboBox cbxStatePlane
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxStatePlane;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxStatePlane != null)
                {
                    _cbxStatePlane.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
                }

                _cbxStatePlane = value;
                if (_cbxStatePlane != null)
                {
                    _cbxStatePlane.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
                }
            }
        }

        private ComboBox _cbxStateCoolant;

        internal ComboBox cbxStateCoolant
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxStateCoolant;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxStateCoolant != null)
                {
                    _cbxStateCoolant.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
                }

                _cbxStateCoolant = value;
                if (_cbxStateCoolant != null)
                {
                    _cbxStateCoolant.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
                }
            }
        }

        private ComboBox _cbxStateSpindle;

        internal ComboBox cbxStateSpindle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxStateSpindle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxStateSpindle != null)
                {
                    _cbxStateSpindle.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
                }

                _cbxStateSpindle = value;
                if (_cbxStateSpindle != null)
                {
                    _cbxStateSpindle.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
                }
            }
        }

        private ComboBox _cbxStateOffset;

        internal ComboBox cbxStateOffset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxStateOffset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxStateOffset != null)
                {
                    _cbxStateOffset.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
                }

                _cbxStateOffset = value;
                if (_cbxStateOffset != null)
                {
                    _cbxStateOffset.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
                }
            }
        }

        private Button _btnOffsetsG28Set;

        internal Button btnOffsetsG28Set
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOffsetsG28Set;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOffsetsG28Set != null)
                {
                    _btnOffsetsG28Set.Click -= btnOffsetsZero_Click;
                }

                _btnOffsetsG28Set = value;
                if (_btnOffsetsG28Set != null)
                {
                    _btnOffsetsG28Set.Click += btnOffsetsZero_Click;
                }
            }
        }

        internal GroupBox GroupBox1;
        internal Label lblPositionCurrentOffset;
        internal GroupBox gbGrblSettings;
        internal BindingSource GrblSettingsBindingSource;
        internal GroupBox gbStatus;
        internal Panel Panel2;
        internal Panel Panel1;
        internal Panel Panel3;
        internal Panel Panel5;
        internal Panel Panel4;
        internal Label Label4;
        internal TextBox tbSettingsGrblLastParam;
        private Button _btnFileReload;

        internal Button btnFileReload
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFileReload;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFileReload != null)
                {
                    _btnFileReload.Click -= btnFileGroup_Click;
                }

                _btnFileReload = value;
                if (_btnFileReload != null)
                {
                    _btnFileReload.Click += btnFileGroup_Click;
                }
            }
        }

        internal Label Label5;
        internal TextBox tbSettingsStartupDelay;
        internal TextBox tbSettingsDefaultExt;
        internal Label Label6;
        internal TabControl tcConnection;
        internal TabPage tbGrblCOM;
        internal TabPage tbGrblIP;
        private Button _btnIPConnect;

        internal Button btnIPConnect
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnIPConnect;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnIPConnect != null)
                {
                    _btnIPConnect.Click -= btnConnDisconnect_Click;
                }

                _btnIPConnect = value;
                if (_btnIPConnect != null)
                {
                    _btnIPConnect.Click += btnConnDisconnect_Click;
                }
            }
        }

        internal TextBox tbIPAddress;
        internal TabPage TabPage1;
        public GroupBox gbEditor;
        private Button _btnAdd;

        private Button btnAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd != null)
                {
                    _btnAdd.Click -= btnAdd_Click;
                }

                _btnAdd = value;
                if (_btnAdd != null)
                {
                    _btnAdd.Click += btnAdd_Click;
                }
            }
        }

        private Label lblGCode;
        private TextBox _tbGCode;

        public TextBox tbGCode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbGCode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbGCode != null)
                {
                    _tbGCode.MouseHover -= UpdateToolTip;
                }

                _tbGCode = value;
                if (_tbGCode != null)
                {
                    _tbGCode.MouseHover += UpdateToolTip;
                }
            }
        }

        private Label lblName;
        private TextBox _tbName;

        public TextBox tbName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbName != null)
                {
                    _tbName.MouseHover -= UpdateToolTip;
                }

                _tbName = value;
                if (_tbName != null)
                {
                    _tbName.MouseHover += UpdateToolTip;
                }
            }
        }

        private Button _btnCancel;

        private Button btnCancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancel != null)
                {
                    _btnCancel.Click -= btnCancel_Click;
                    _btnCancel.MouseHover -= UpdateToolTip;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += btnCancel_Click;
                    _btnCancel.MouseHover += UpdateToolTip;
                }
            }
        }

        private Button _btnOK;

        private Button btnOK
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOK;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOK != null)
                {
                    _btnOK.Click -= btnOK_Click;
                    _btnOK.MouseHover -= UpdateToolTip;
                }

                _btnOK = value;
                if (_btnOK != null)
                {
                    _btnOK.Click += btnOK_Click;
                    _btnOK.MouseHover += UpdateToolTip;
                }
            }
        }

        private DataGridView _dgMacros;

        private DataGridView dgMacros
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgMacros;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgMacros != null)
                {
                    _dgMacros.CellValueChanged -= dgMacros_CellValueChanged;
                    _dgMacros.DoubleClick -= dgMacros_DoubleClick;
                    _dgMacros.MouseHover -= UpdateToolTip;
                }

                _dgMacros = value;
                if (_dgMacros != null)
                {
                    _dgMacros.CellValueChanged += dgMacros_CellValueChanged;
                    _dgMacros.DoubleClick += dgMacros_DoubleClick;
                    _dgMacros.MouseHover += UpdateToolTip;
                }
            }
        }

        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        private Label lblStatusLabel;
        private Button _btnDeleteMacro;

        private Button btnDeleteMacro
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDeleteMacro;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDeleteMacro != null)
                {
                    _btnDeleteMacro.Click -= btnDeleteMacro_Click;
                    _btnDeleteMacro.MouseHover -= UpdateToolTip;
                }

                _btnDeleteMacro = value;
                if (_btnDeleteMacro != null)
                {
                    _btnDeleteMacro.Click += btnDeleteMacro_Click;
                    _btnDeleteMacro.MouseHover += UpdateToolTip;
                }
            }
        }

        internal GroupBox gbOverrides;
        internal Label Label46;
        private Button _btnFeedMinus;

        internal Button btnFeedMinus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFeedMinus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFeedMinus != null)
                {
                    _btnFeedMinus.Click -= btnFeedOverride_Click;
                }

                _btnFeedMinus = value;
                if (_btnFeedMinus != null)
                {
                    _btnFeedMinus.Click += btnFeedOverride_Click;
                }
            }
        }

        private Button _btnFeedPlus;

        internal Button btnFeedPlus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFeedPlus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFeedPlus != null)
                {
                    _btnFeedPlus.Click -= btnFeedOverride_Click;
                }

                _btnFeedPlus = value;
                if (_btnFeedPlus != null)
                {
                    _btnFeedPlus.Click += btnFeedOverride_Click;
                }
            }
        }

        private Button _btnSetOffsetG59;

        internal Button btnSetOffsetG59
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSetOffsetG59;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetOffsetG59 != null)
                {
                    _btnSetOffsetG59.Click -= btnSetOffset_Click;
                }

                _btnSetOffsetG59 = value;
                if (_btnSetOffsetG59 != null)
                {
                    _btnSetOffsetG59.Click += btnSetOffset_Click;
                }
            }
        }

        private Button _btnSetOffsetG58;

        internal Button btnSetOffsetG58
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSetOffsetG58;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetOffsetG58 != null)
                {
                    _btnSetOffsetG58.Click -= btnSetOffset_Click;
                }

                _btnSetOffsetG58 = value;
                if (_btnSetOffsetG58 != null)
                {
                    _btnSetOffsetG58.Click += btnSetOffset_Click;
                }
            }
        }

        private Button _btnSetOffsetG57;

        internal Button btnSetOffsetG57
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSetOffsetG57;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetOffsetG57 != null)
                {
                    _btnSetOffsetG57.Click -= btnSetOffset_Click;
                }

                _btnSetOffsetG57 = value;
                if (_btnSetOffsetG57 != null)
                {
                    _btnSetOffsetG57.Click += btnSetOffset_Click;
                }
            }
        }

        private Button _btnSetOffsetG56;

        internal Button btnSetOffsetG56
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSetOffsetG56;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetOffsetG56 != null)
                {
                    _btnSetOffsetG56.Click -= btnSetOffset_Click;
                }

                _btnSetOffsetG56 = value;
                if (_btnSetOffsetG56 != null)
                {
                    _btnSetOffsetG56.Click += btnSetOffset_Click;
                }
            }
        }

        private Button _btnSetOffsetG55;

        internal Button btnSetOffsetG55
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSetOffsetG55;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetOffsetG55 != null)
                {
                    _btnSetOffsetG55.Click -= btnSetOffset_Click;
                }

                _btnSetOffsetG55 = value;
                if (_btnSetOffsetG55 != null)
                {
                    _btnSetOffsetG55.Click += btnSetOffset_Click;
                }
            }
        }

        private Button _btnSetOffsetG54;

        internal Button btnSetOffsetG54
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSetOffsetG54;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetOffsetG54 != null)
                {
                    _btnSetOffsetG54.Click -= btnSetOffset_Click;
                }

                _btnSetOffsetG54 = value;
                if (_btnSetOffsetG54 != null)
                {
                    _btnSetOffsetG54.Click += btnSetOffset_Click;
                }
            }
        }

        private DataGridView _dgvGcode;

        internal DataGridView dgvGcode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvGcode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvGcode != null)
                {
                    _dgvGcode.CellValueNeeded -= dgvGcode_CellValueNeeded;
                }

                _dgvGcode = value;
                if (_dgvGcode != null)
                {
                    _dgvGcode.CellValueNeeded += dgvGcode_CellValueNeeded;
                }
            }
        }

        internal TextBox tbSpindleOvr;
        internal TextBox tbRapidOvr;
        internal TextBox tbFeedOvr;
        internal Label Label44;
        private Button _btnSpindleMinus;

        internal Button btnSpindleMinus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSpindleMinus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSpindleMinus != null)
                {
                    _btnSpindleMinus.Click -= btnSpindleOverride_Click;
                }

                _btnSpindleMinus = value;
                if (_btnSpindleMinus != null)
                {
                    _btnSpindleMinus.Click += btnSpindleOverride_Click;
                }
            }
        }

        private Button _btnSpindlePlus;

        internal Button btnSpindlePlus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSpindlePlus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSpindlePlus != null)
                {
                    _btnSpindlePlus.Click -= btnSpindleOverride_Click;
                }

                _btnSpindlePlus = value;
                if (_btnSpindlePlus != null)
                {
                    _btnSpindlePlus.Click += btnSpindleOverride_Click;
                }
            }
        }

        internal Label Label22;
        private Button _btnRapidOverride50;

        internal Button btnRapidOverride50
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRapidOverride50;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRapidOverride50 != null)
                {
                    _btnRapidOverride50.Click -= btnRapidOverride_Click;
                }

                _btnRapidOverride50 = value;
                if (_btnRapidOverride50 != null)
                {
                    _btnRapidOverride50.Click += btnRapidOverride_Click;
                }
            }
        }

        private Button _btnRapidOverrideReset;

        internal Button btnRapidOverrideReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRapidOverrideReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRapidOverrideReset != null)
                {
                    _btnRapidOverrideReset.Click -= btnRapidOverride_Click;
                    _btnRapidOverrideReset.Click -= btnFeedOverrideReset_Click;
                }

                _btnRapidOverrideReset = value;
                if (_btnRapidOverrideReset != null)
                {
                    _btnRapidOverrideReset.Click += btnRapidOverride_Click;
                    _btnRapidOverrideReset.Click += btnFeedOverrideReset_Click;
                }
            }
        }

        private Button _btnFeedOverrideReset;

        internal Button btnFeedOverrideReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFeedOverrideReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFeedOverrideReset != null)
                {
                    _btnFeedOverrideReset.Click -= btnFeedOverrideReset_Click;
                }

                _btnFeedOverrideReset = value;
                if (_btnFeedOverrideReset != null)
                {
                    _btnFeedOverrideReset.Click += btnFeedOverrideReset_Click;
                }
            }
        }

        internal CheckBox cbFeedCoarse;
        private Button _btnSpindleOverrideReset;

        internal Button btnSpindleOverrideReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSpindleOverrideReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSpindleOverrideReset != null)
                {
                    _btnSpindleOverrideReset.Click -= btnFeedOverrideReset_Click;
                }

                _btnSpindleOverrideReset = value;
                if (_btnSpindleOverrideReset != null)
                {
                    _btnSpindleOverrideReset.Click += btnFeedOverrideReset_Click;
                }
            }
        }

        private Button _btnRapidOverride25;

        internal Button btnRapidOverride25
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRapidOverride25;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRapidOverride25 != null)
                {
                    _btnRapidOverride25.Click -= btnRapidOverride_Click;
                }

                _btnRapidOverride25 = value;
                if (_btnRapidOverride25 != null)
                {
                    _btnRapidOverride25.Click += btnRapidOverride_Click;
                }
            }
        }

        internal CheckBox cbSpindleCoarse;
        internal CheckBox cbStartResume;
        internal CheckBox cbFeedHold;
        internal CheckBox cbResetAbort;
        internal CheckBox cbDoorOpen;
        internal CheckBox cbProbePin;
        internal CheckBox cbLimitZ;
        internal CheckBox cbLimitY;
        internal CheckBox cbLimitX;
        internal GroupBox gbPinStatus;
        internal Label lblElapsedTime;
        internal Label Label23;
        internal Label Label51;
        internal Label lblCurrentLine;
        internal DataGridViewTextBoxColumn stat;
        internal DataGridViewTextBoxColumn lineNum;
        internal DataGridViewTextBoxColumn data;
        internal CheckBox cbMonitorEnable;
        private Button _btnMistOverride;

        internal Button btnMistOverride
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnMistOverride;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMistOverride != null)
                {
                    _btnMistOverride.Click -= btnToggleOverride_Click;
                }

                _btnMistOverride = value;
                if (_btnMistOverride != null)
                {
                    _btnMistOverride.Click += btnToggleOverride_Click;
                }
            }
        }

        private Button _btnFloodOverride;

        internal Button btnFloodOverride
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFloodOverride;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFloodOverride != null)
                {
                    _btnFloodOverride.Click -= btnToggleOverride_Click;
                }

                _btnFloodOverride = value;
                if (_btnFloodOverride != null)
                {
                    _btnFloodOverride.Click += btnToggleOverride_Click;
                }
            }
        }

        private Button _btnSpindleOverride;

        internal Button btnSpindleOverride
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSpindleOverride;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSpindleOverride != null)
                {
                    _btnSpindleOverride.Click -= btnToggleOverride_Click;
                }

                _btnSpindleOverride = value;
                if (_btnSpindleOverride != null)
                {
                    _btnSpindleOverride.Click += btnToggleOverride_Click;
                }
            }
        }

        internal GroupBox gbMiscInfo;
        internal Label Label48;
        internal TextBox tbGrblVersion;
        internal Label Label49;
        internal TextBox tbGrblOptions;
        private Button _btnFileStep;

        internal Button btnFileStep
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFileStep;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFileStep != null)
                {
                    _btnFileStep.Click -= btnFileGroup_Click;
                }

                _btnFileStep = value;
                if (_btnFileStep != null)
                {
                    _btnFileStep.Click += btnFileGroup_Click;
                }
            }
        }

        internal TextBox tbTruncationDigits;
        internal Label Label52;
    }
}