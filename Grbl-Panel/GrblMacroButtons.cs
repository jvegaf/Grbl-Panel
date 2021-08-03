using System;
using System.Linq;
using System.Windows.Forms;
using GrblPanel.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    public partial class GrblGui
    {
        private bool bDataChanged = false;
        /// <summary>
    /// The fixed names of Macros in Settings
    /// </summary>
        private string[] _macroNames = new string[] { "Macro1", "Macro2", "Macro3", "Macro4", "Macro5" };

        private void GrblMacroButtons_FormClosing(object sender, FormClosingEventArgs e)
        {
            int retval;
            if (bDataChanged)
            {
                retval = (int)Interaction.MsgBox(Resources.GrblGui_GrblMacroButtons_FormClosing_AreYouSureYouWantToExitWithoutSavingYourMacroChanges, (MsgBoxStyle)((int)MsgBoxStyle.YesNo + (int)MsgBoxStyle.Critical), Resources.GrblGui_GrblMacroButtons_FormClosing_ConfirmExitWithoutSaving);
                if (retval == (int)Constants.vbYes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void GrblMacroButtons_Load(object sender, EventArgs e)
        {
            FillListFromSettings();
            {
                var withBlock = dgMacros;
                withBlock.Columns[0].Width = withBlock.Width;         // resize the first column to the width of the entire grid, this hides the Gcode column
                                                                      // If .RowCount = 0 Then              ' if there are no macros add a default one to the list as an example
                                                                      // .Rows.Add("Probe", "G38.2 Z-30 F10")
                                                                      // bDataChanged = True
                                                                      // End If
            }

            btnAdd.Text = Resources.GrblGui_GrblMacroButtons_Load_Add;
            tbName.Text = "";
            tbGCode.Text = "";
        }

        private void FillListFromSettings()
        {
            string[] sTemp;
            {
                var withBlock = dgMacros;
                withBlock.RowCount = 0;                                    // make sure the grid is empty
                foreach (string KeyName in _macroNames) // add records to the grid 
                {
                    sTemp = Strings.Split(Conversions.ToString(My.MySettingsProperty.Settings[KeyName]), ":");
                    if (sTemp.Count() == 2)
                    {
                        withBlock.Rows.Add(sTemp[0], sTemp[1]);
                    }
                }

                bDataChanged = false;                             // reset our changed data flag
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveMacros();
            DialogResult = DialogResult.OK;
        }

        private void SaveMacros()
        {
            int index = 0;
            foreach (var macro in _macroNames)
                My.MySettingsProperty.Settings[macro] = "";
            foreach (DataGridViewRow row in dgMacros.Rows)
            {
                My.MySettingsProperty.Settings[_macroNames[index]] = row.Cells[0].Value.ToString() + ":" + row.Cells[1].Value.ToString();
                index += 1;
            }

            My.MySettingsProperty.Settings.Save();
            bDataChanged = false;

            // reload onto MDI display
            EnableMacroButtons();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgMacros_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bDataChanged = true;
        }

        private void dgMacros_DoubleClick(object sender, EventArgs e)
        {
            {
                var withBlock = dgMacros;
                if (withBlock.CurrentRow.Index >= 0)
                {
                    tbName.Text = Conversions.ToString(withBlock[0, withBlock.CurrentRow.Index].Value);
                    tbGCode.Text = Conversions.ToString(withBlock[1, withBlock.CurrentRow.Index].Value);
                    btnAdd.Text = Resources.GrblGui_dgMacros_DoubleClick_Update;
                }
            }
        }

        private void btnDeleteMacro_Click(object sender, EventArgs e)
        {
            int retval;
            string sMsg;
            {
                var withBlock = dgMacros;
                if (withBlock.CurrentRow.Index >= 0)
                {
                    sMsg = Resources.GrblGui_btnDeleteMacro_Click_AreYouSureYouWantToDeleteThe + withBlock[0, withBlock.CurrentRow.Index].Value.ToString() + " macro?";
                    retval = (int)Interaction.MsgBox(sMsg, (MsgBoxStyle)((int)MsgBoxStyle.YesNo + (int)MsgBoxStyle.Critical), Resources.GrblGui_btnDeleteMacro_Click_ConfirmDelete);
                    if (retval == (int)Constants.vbYes)
                    {
                        withBlock.Rows.Remove(withBlock.CurrentRow);
                        bDataChanged = true;
                    }
                }
            }
        }

        private void UpdateToolTip(object sender, EventArgs e)
        {
            string sTemp;
            if (ReferenceEquals(sender, tbName))
            {
                sTemp = Resources.GrblGui_UpdateToolTip_NameAppearsOnTheButtonSoKeepItSmall;
            }
            else if (ReferenceEquals(sender, btnDeleteMacro))
            {
                sTemp = Resources.GrblGui_UpdateToolTip_DeleteTheSelectedMacro;
            }
            else if (ReferenceEquals(sender, dgMacros))
            {
                sTemp = Resources.GrblGui_UpdateToolTip_DblClickNameToEditMacro;
            }
            else if (ReferenceEquals(sender, btnCancel))
            {
                sTemp = Resources.GrblGui_UpdateToolTip_GetMeOuttaHereCancelAllChanges;
            }
            else if (ReferenceEquals(sender, tbGCode))
            {
                sTemp = Resources.GrblGui_UpdateToolTip_GCodeToSendWhenTheButtonIsClicked;
            }
            else if (ReferenceEquals(sender, btnOK))
            {
                sTemp = Resources.GrblGui_UpdateToolTip_CommitAllChangesToSettingsAndClose;
            }
            else
            {
                sTemp = Resources.GrblGui_UpdateToolTip_LimitIs5Macros;
            }

            lblStatusLabel.Text = sTemp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var bMatchFound = default(bool);
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                if (!string.IsNullOrEmpty(tbGCode.Text))
                {
                    if ((btnAdd.Text ?? "") == (Resources.GrblGui_dgMacros_DoubleClick_Update ?? ""))
                    {
                        foreach (DataGridViewRow row in dgMacros.Rows)
                        {
                            if ((row.Cells[0].Value.ToString() ?? "") == (tbName.Text ?? ""))
                            {
                                row.Cells[1].Value = tbGCode.Text.ToUpper();
                                bMatchFound = true;
                                break;
                            }
                        }
                        // if the user changed the name we cannot update so we need to add
                        if (!bMatchFound)
                        {
                            dgMacros.Rows.Add(tbName.Text, tbGCode.Text);
                        }
                    }
                    else
                    {
                        dgMacros.Rows.Add(tbName.Text, tbGCode.Text.ToUpper());
                    }

                    bDataChanged = true;
                    btnAdd.Text = Resources.GrblGui_GrblMacroButtons_Load_Add;
                    tbGCode.Text = "";
                    tbName.Text = "";
                }
                else
                {
                    Interaction.MsgBox(Resources.GrblGui_btnAdd_Click_YouNeedToAddSomeGCodeToSaveAMacro, MsgBoxStyle.Information, Resources.GrblGui_btnAdd_Click_DataValidationError);
                }
            }
            else
            {
                Interaction.MsgBox(Resources.GrblGui_btnAdd_Click_YouCannotCreateAMacroWithoutAName, MsgBoxStyle.Information, Resources.GrblGui_btnAdd_Click_DataValidationError);
            }
        }

        public Button IsMacroBtn(int num)
        {
            for (int iLoopCounter = gbMDI.Controls.Count - 1; iLoopCounter >= 0; iLoopCounter -= 1)
            {
                var mButton = gbMDI.Controls[iLoopCounter];
                string m = "btnMacro" + (num - 1);
                if ((mButton.Name ?? "") == (m ?? "")) // "btnMacro" + ToString(num - 1) Then
                {
                    return (Button)mButton;
                }
            }

            return null;
        }

        public string[] macroNames
        {
            get
            {
                return _macroNames;
            }
        }
    }
}