using FormValidationExample.Model;
using FormValidationExample.Views.Args;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FormValidationExample.Views
{
  
    [ToolboxItem(true)]
    public partial class AnalogSignalView : UserControl, IAnalogSignalView
    {
        public event EventHandler<ValueChangedEventArgs> SignalNameChanged;

        public AnalogSignalView()
        {
            InitializeComponent();
        }

        public void LoadModel(IAnalogSignal analogSignal) {

            //Dissable events

            txtName.Text = analogSignal.Name;
            txtValue.Text = analogSignal.Value;

            //Enable events

        }

        #region Name Textbox behavior
        private void txtName_TextChanged(object sender, System.EventArgs e)
        {
            if (!MatchesConvention(txtName.Text))
            {
                errorProvider.SetError(txtName, "Name should start with a letter and contain only letters and numbers!");
            }
            else {
                errorProvider.SetError(txtName, "");
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!MatchesConvention(txtName.Text))
            {
                errorProvider.SetError(txtName, "Name should start with a letter and contain only letters and numbers!");
                e.Cancel = true;
            }
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
                errorProvider.SetError(txtName, "");

                ValueChangedEventArgs arg = new ValueChangedEventArgs {
                    Value = txtName.Text
                };

                SignalNameChanged?.Invoke(this, arg);          
        }


        public void InvalidateSignalName(string message)
        {
            errorProvider.SetError(txtName, message);
        }

        #endregion

        private bool MatchesConvention(string value)
        {

            return !value.Contains(" ");
        }
    }
}
