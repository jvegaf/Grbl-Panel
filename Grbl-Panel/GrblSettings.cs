using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GrblPanel.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    public partial class GrblGui
    {
        public GrblGui()
        {
            _errors = initial_errors();
            InitializeComponent();
            _ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            _OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            _AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            _btnMistOverride.Name = "btnMistOverride";
            _btnFloodOverride.Name = "btnFloodOverride";
            _btnSpindleOverride.Name = "btnSpindleOverride";
            _btnSpindleOverrideReset.Name = "btnSpindleOverrideReset";
            _btnRapidOverride25.Name = "btnRapidOverride25";
            _btnFeedOverrideReset.Name = "btnFeedOverrideReset";
            _btnSpindleMinus.Name = "btnSpindleMinus";
            _btnSpindlePlus.Name = "btnSpindlePlus";
            _btnRapidOverride50.Name = "btnRapidOverride50";
            _btnRapidOverrideReset.Name = "btnRapidOverrideReset";
            _btnFeedMinus.Name = "btnFeedMinus";
            _btnFeedPlus.Name = "btnFeedPlus";
            _btnStatusClearPins.Name = "btnStatusClearPins";
            _cbxStateFeedMode.Name = "cbxStateFeedMode";
            _cbxStateDistance.Name = "cbxStateDistance";
            _cbxStateUnits.Name = "cbxStateUnits";
            _cbxStatePlane.Name = "cbxStatePlane";
            _cbxStateOffset.Name = "cbxStateOffset";
            _cbxStateCoolant.Name = "cbxStateCoolant";
            _cbxStateSpindle.Name = "cbxStateSpindle";
            _btnCheckMode.Name = "btnCheckMode";
            _btnReset.Name = "btnReset";
            _btnHold.Name = "btnHold";
            _btnStartResume.Name = "btnStartResume";
            _btnUnlock.Name = "btnUnlock";
            _btnSend.Name = "btnSend";
            _tbSendData.Name = "tbSendData";
            _btnZMinus.Name = "btnZMinus";
            _btnZPlus.Name = "btnZPlus";
            _btnXPlus.Name = "btnXPlus";
            _btnYMinus.Name = "btnYMinus";
            _btnXMinus.Name = "btnXMinus";
            _btnYPlus.Name = "btnYPlus";
            _rbFeedRate1.Name = "rbFeedRate1";
            _rbFeedRate2.Name = "rbFeedRate2";
            _rbFeedRate3.Name = "rbFeedRate3";
            _rbFeedRate4.Name = "rbFeedRate4";
            _rbDistance1.Name = "rbDistance1";
            _rbDistance2.Name = "rbDistance2";
            _rbDistance3.Name = "rbDistance3";
            _rbDistance4.Name = "rbDistance4";
            _cbUnits.Name = "cbUnits";
            _btnFileStep.Name = "btnFileStep";
            _dgvGcode.Name = "dgvGcode";
            _btnFileReload.Name = "btnFileReload";
            _btnFilePause.Name = "btnFilePause";
            _btnFileSelect.Name = "btnFileSelect";
            _btnFileSend.Name = "btnFileSend";
            _btnFileStop.Name = "btnFileStop";
            _btnRescanPorts.Name = "btnRescanPorts";
            _cbPorts.Name = "cbPorts";
            _btnConnect.Name = "btnConnect";
            _cbBaud.Name = "cbBaud";
            _btnIPConnect.Name = "btnIPConnect";
            _tbWorkZ.Name = "tbWorkZ";
            _tbWorkY.Name = "tbWorkY";
            _tbWorkX.Name = "tbWorkX";
            _btnWorkSoftHome.Name = "btnWorkSoftHome";
            _btnHome.Name = "btnHome";
            _btnWorkSpclPosition.Name = "btnWorkSpclPosition";
            _btnWork0.Name = "btnWork0";
            _btnWorkX0.Name = "btnWorkX0";
            _btnWorkZ0.Name = "btnWorkZ0";
            _btnWorkY0.Name = "btnWorkY0";
            _btnSetOffsetG59.Name = "btnSetOffsetG59";
            _btnSetOffsetG58.Name = "btnSetOffsetG58";
            _btnSetOffsetG57.Name = "btnSetOffsetG57";
            _btnSetOffsetG56.Name = "btnSetOffsetG56";
            _btnSetOffsetG55.Name = "btnSetOffsetG55";
            _btnSetOffsetG54.Name = "btnSetOffsetG54";
            _tbOffsetsG56Y.Name = "tbOffsetsG56Y";
            _tbOffsetsG56X.Name = "tbOffsetsG56X";
            _tbOffsetsG56Z.Name = "tbOffsetsG56Z";
            _btnOffsetsG57Zero.Name = "btnOffsetsG57Zero";
            _tbOffsetsG54X.Name = "tbOffsetsG54X";
            _btnOffsetsG56Zero.Name = "btnOffsetsG56Zero";
            _tbOffsetsG54Y.Name = "tbOffsetsG54Y";
            _tbOffsetsG57Z.Name = "tbOffsetsG57Z";
            _btnOffsetsSave.Name = "btnOffsetsSave";
            _tbOffsetsG55X.Name = "tbOffsetsG55X";
            _tbOffsetsG54Z.Name = "tbOffsetsG54Z";
            _tbOffsetsG57Y.Name = "tbOffsetsG57Y";
            _btnOffsetsRetrieve.Name = "btnOffsetsRetrieve";
            _tbOffsetsG55Y.Name = "tbOffsetsG55Y";
            _btnOffsetsG54Zero.Name = "btnOffsetsG54Zero";
            _tbOffsetsG57X.Name = "tbOffsetsG57X";
            _btnOffsetsLoad.Name = "btnOffsetsLoad";
            _tbOffsetsG55Z.Name = "tbOffsetsG55Z";
            _tbOffsetsG59X.Name = "tbOffsetsG59X";
            _btnOffsetsG58Zero.Name = "btnOffsetsG58Zero";
            _btnOffsetsG43Zero.Name = "btnOffsetsG43Zero";
            _tbOffsetsG59Y.Name = "tbOffsetsG59Y";
            _tbOffsetsG43Z.Name = "tbOffsetsG43Z";
            _btnOffsetsG55Zero.Name = "btnOffsetsG55Zero";
            _tbOffsetsG59Z.Name = "tbOffsetsG59Z";
            _tbOffsetsG58Z.Name = "tbOffsetsG58Z";
            _tbOffsetsG58Y.Name = "tbOffsetsG58Y";
            _btnOffsetsG59Zero.Name = "btnOffsetsG59Zero";
            _tbOffsetsG58X.Name = "tbOffsetsG58X";
            _dgGrblSettings.Name = "dgGrblSettings";
            _btnSettingsGrbl.Name = "btnSettingsGrbl";
            _btnOffsetsG28Set.Name = "btnOffsetsG28Set";
            _btnSettingsRetrieveLocations.Name = "btnSettingsRetrieveLocations";
            _btnOffsetsG30Set.Name = "btnOffsetsG30Set";
            _btnSettingsRefreshMisc.Name = "btnSettingsRefreshMisc";
            _btnSettingsRefreshPosition.Name = "btnSettingsRefreshPosition";
            _btnSettingsRefreshJogging.Name = "btnSettingsRefreshJogging";
            _btnAdd.Name = "btnAdd";
            _tbGCode.Name = "tbGCode";
            _tbName.Name = "tbName";
            _btnCancel.Name = "btnCancel";
            _btnOK.Name = "btnOK";
            _dgMacros.Name = "dgMacros";
            _btnDeleteMacro.Name = "btnDeleteMacro";
            _cbSettingsLeftHanded.Name = "cbSettingsLeftHanded";
            _cbSettingsMetric.Name = "cbSettingsMetric";
        }

        public class GrblSettings
        {

            public GrblSettings(ref GrblGui gui)
            {
                _settings = new Dictionary<string, string>() { { "0", Resources.GrblSettings_StepPulseUsec }, { "1", Resources.GrblSettings_StepIdleDelayMsec }, { "2", Resources.GrblSettings_StepPortInvertMask }, { "3", Resources.GrblSettings_DirPortInvertMask }, { "4", Resources.GrblSettings_StepEnableInvertBool }, { "5", Resources.GrblSettings_LimitPinsInvertBool }, { "6", Resources.GrblSettings_ProbePinInvertBool }, { "10", Resources.GrblSettings_StatusReportMask }, { "11", Resources.GrblSettings_JunctionDeviationMm }, { "12", Resources.GrblSettings_ArcToleranceMm }, { "13", Resources.GrblSettings_ReportInchesBool }, { "20", Resources.GrblSettings_SoftLimitsBool }, { "21", Resources.GrblSettings_HardLimitsBool }, { "22", Resources.GrblSettings_HomingCycleBool }, { "23", Resources.GrblSettings_HomingDirInvertMask }, { "24", Resources.GrblSettings_HomingFeedMmMin }, { "25", Resources.GrblSettings_HomingSeekMmMin }, { "26", Resources.GrblSettings_HomingDebounceMsec }, { "27", Resources.GrblSettings_HomingPullOffMm }, { "30", Resources.GrblSettings_RpmMax }, { "31", Resources.GrblSettings_RpmMin }, { "32", Resources.GrblSettings_LaserMode }, { "100", Resources.GrblSettings_XStepMm }, { "101", Resources.GrblSettings_YStepMm }, { "102", Resources.GrblSettings_ZStepMm }, { "103", Resources.GrblSettings_AStepMm }, { "110", Resources.GrblSettings_XMaxRateMmMin }, { "111", Resources.GrblSettings_YMaxRateMmMin }, { "112", Resources.GrblSettings_ZMaxRateMmMin }, { "113", Resources.GrblSettings_AMaxRateMmMin }, { "120", Resources.GrblSettings_XAccelMmSec2 }, { "121", Resources.GrblSettings_YAccelMmSec2 }, { "122", Resources.GrblSettings_ZAccelMmSec2 }, { "123", Resources.GrblSettings_AAccelMmSec2 }, { "130", Resources.GrblSettings_XMaxTravelMm }, { "131", Resources.GrblSettings_YMaxTravelMm }, { "132", Resources.GrblSettings_ZMaxTravelMm }, { "133", Resources.GrblSettings_AMaxTravelMm } };
                // Get ref to parent object
                _gui = gui;
                // For Connected events
                _gui.Connected += GrblConnected;
            }
            // Handle settings related operations


            private GrblGui _gui;
            private DataTable _paramTable;    // to hold the parameters
            private int _nextParam;       // to track which param line is next
            private Dictionary<string, string> _settings;
            #region Properties
            public int IsHomingEnabled
            {
                get
                {
                    DataRow row;
                    row = _paramTable.Rows.Find("$22");
                    if (!Information.IsNothing(row))
                    {
                        return Conversions.ToInteger(row[Resources.GrblSettings_FillSettings_Value]);
                    }

                    return 0;
                }
            }
            /// <summary>
        /// Gets a value indicating whether Grbl is override capable.
        /// </summary>
        /// <value>
        /// <c>true</c> if Grbl is override capable; otherwise, <c>false</c>.
        /// </value>
            public bool IsOverrideCapable
            {
                get
                {
                    DataRow row;
                    row = _paramTable.Rows.Find("$31");
                    if (!Information.IsNothing(row))
                    {
                        return true;
                    }

                    return false;
                }
            }
            /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
            public bool IsGrblMetric
            {
                get
                {
                    DataRow row;
                    row = _paramTable.Rows.Find("$13");
                    if (!Information.IsNothing(row))
                    {
                        if (Conversions.ToString(row[1].ToString()[0]) == "0")
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }

            public void EnableState(bool yes)
            {
                if (yes)
                {
                    _gui.gbGrblSettings.Enabled = true;
                }
                else
                {
                    _gui.gbGrblSettings.Enabled = false;
                }
            }

            private void GrblConnected(string msg)     // Handles GrblGui.Connected Event
            {
                if (msg == "Connected")
                {

                    // We are connected to Grbl so populate the Settings
                    _nextParam = 0;
                    gcode.sendGCodeLine("$$");
                }
            }

            public void FillSettings(string data)
            {
                // Add a settings line to the display
                // Console.WriteLine("GrblSettings: $ Data is : " + data)
                // Return
                string[] @params;
                int index;
                if (_nextParam == 0)
                {
                    // We are dealing with a fresh
                    _paramTable = new DataTable();
                    {
                        var withBlock = _paramTable;
                        withBlock.Columns.Add("ID");
                        withBlock.Columns.Add(Resources.GrblSettings_FillSettings_Value);
                        withBlock.Columns.Add("Description");
                        withBlock.PrimaryKey = new DataColumn[] { withBlock.Columns["ID"] };
                    }
                }

                @params = data.Split(new[] { '=', '(', ')' });
                @params[1] = @params[1].Replace(" ", "");         // strip trailing blanks
                if (@params.Count() == 4)
                {
                    _paramTable.Rows.Add(@params[0], @params[1], @params[2]);
                }
                else
                {
                    // We have Grbl in GUI mode, so add Description manually
                    index = Conversions.ToInteger(@params[0].Remove(0, 1));      // remove the leading $
                    if (_settings.ContainsKey(index.ToString()))
                    {
                        _paramTable.Rows.Add(@params[0], @params[1], _settings[index.ToString()]);
                    }
                    else
                    {
                        _paramTable.Rows.Add(@params[0], @params[1], "");
                    }
                }

                _nextParam += 1;
                if ((@params[0] ?? "") == (_gui.tbSettingsGrblLastParam.Text ?? "")) // We got the last one
                {
                    _nextParam = 0;            // in case user does a MDI $$
                    {
                        var withBlock1 = _gui.dgGrblSettings;
                        withBlock1.DataSource = _paramTable;
                        withBlock1.Columns["ID"].Width = 40;
                        withBlock1.Columns["ID"].ReadOnly = true;
                        withBlock1.Columns["ID"].DefaultCellStyle.BackColor = SystemColors.Control;
                        withBlock1.Columns[Resources.GrblSettings_FillSettings_Value].Width = 60;
                        withBlock1.Columns["Description"].Width = 200;
                        withBlock1.Columns["Description"].ReadOnly = true;
                        withBlock1.Columns["Description"].DefaultCellStyle.BackColor = SystemColors.Control;
                        withBlock1.Refresh();
                    }
                    // Tell everyone we have the params
                    GrblSettingsRetrievedEvent?.Invoke();
                }
            }

            // Event template for Settings Retrieved indication
            public event GrblSettingsRetrievedEventEventHandler GrblSettingsRetrievedEvent;

            public delegate void GrblSettingsRetrievedEventEventHandler();

            public void RefreshSettings()
            {
                _nextParam = 0;
                gcode.sendGCodeLine("$$");
            }

            #endregion
        }

        // We need a way to propogate changes on the Settings tab, do that here

        private void btnSettingsRefreshMisc_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch ((string)b.Tag ?? "")
            {
                case "Misc":
                    {
                        changeStatusRate(Conversions.ToInteger(My.MySettingsProperty.Settings.StatusPollInterval));
                        prgBarQ.Maximum = Conversions.ToInteger(My.MySettingsProperty.Settings.QBuffMaxSize);
                        prgbRxBuf.Maximum = Conversions.ToInteger(My.MySettingsProperty.Settings.RBuffMaxSize);
                        cbStatusPollEnable.Checked = My.MySettingsProperty.Settings.StatusPollEnabled;
                        cbSettingsConnectOnLoad.Checked = My.MySettingsProperty.Settings.GrblConnectOnLoad;
                        break;
                    }

                case "Position":
                    {
                        tbSettingsSpclPosition1.Text = My.MySettingsProperty.Settings.MachineSpclPosition1;
                        tbSettingsSpclPosition2.Text = My.MySettingsProperty.Settings.MachineSpclPosition2;
                        break;
                    }

                case "Jogging":
                    {
                        tbSettingsFIImperial.Text = My.MySettingsProperty.Settings.JoggingFIImperial;
                        tbSettingsFRImperial.Text = My.MySettingsProperty.Settings.JoggingFRImperial;
                        tbSettingsFIMetric.Text = My.MySettingsProperty.Settings.JoggingFIMEtric;
                        tbSettingsFRMetric.Text = My.MySettingsProperty.Settings.JoggingFRMetric;
                        cbSettingsMetric.Checked = My.MySettingsProperty.Settings.JoggingUnitsMetric;
                        setDistanceMetric(cbSettingsMetric.Checked);
                        btnXPlus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(My.MySettingsProperty.Settings.JoggingXRepeat));
                        btnXMinus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(My.MySettingsProperty.Settings.JoggingXRepeat));
                        btnYPlus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(My.MySettingsProperty.Settings.JoggingYRepeat));
                        btnYMinus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(My.MySettingsProperty.Settings.JoggingYRepeat));
                        btnZPlus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(My.MySettingsProperty.Settings.JoggingZRepeat));
                        btnZMinus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(My.MySettingsProperty.Settings.JoggingZRepeat));
                        break;
                    }
            }
        }

        private void btnSettingsGrbl_Click(object sender, EventArgs e)
        {
            // Retrieve settings from Grbl
            settings.RefreshSettings();
        }

        private void dgGrblSettings_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // User wants to edit a Grbl setting
            // We do these one at a time due to EEProm write restrictions
            // Psuedo code:
            // Which row? Get new value, determine $id, send to Grbl, do a refresh ($$)
            if (e.ColumnIndex != 1)
            {
                // ignore the click, it is not in Value column
                return;
            }

            DataGridView gridView = (DataGridView)sender;
            if (!Information.IsNothing(gridView.EditingControl))
            {
                // we have something to change (aka ignore errant double clicks)
                string param = gridView.Rows[e.RowIndex].Cells[0].Value.ToString() + "=" + gridView.EditingControl.Text;
                gcode.sendGCodeLine(param);
                System.Threading.Thread.Sleep(200);              // Have to wait for EEProm write
                gcode.sendGCodeLine("$$");   // Refresh
            }
        }
    }
}