namespace CestovnePrikazy.Forms
{
    partial class DeleteTravelOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            state = new Label();
            labelTransport = new Label();
            labelEnd = new Label();
            labelStart = new Label();
            labelFinalCity = new Label();
            labelStartCity = new Label();
            labelEmployee = new Label();
            checkedListBoxTransport = new CheckedListBox();
            buttonConfirm = new Button();
            removeTravelOrder = new Label();
            comboBoxState = new ComboBox();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            comboBoxFinalCity = new ComboBox();
            comboBoxStartCity = new ComboBox();
            comboBoxEmployee = new ComboBox();
            SuspendLayout();
            // 
            // state
            // 
            state.AutoSize = true;
            state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            state.Location = new Point(42, 488);
            state.Name = "state";
            state.Size = new Size(39, 21);
            state.TabIndex = 54;
            state.Text = "Stav";
            // 
            // labelTransport
            // 
            labelTransport.AutoSize = true;
            labelTransport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTransport.Location = new Point(42, 334);
            labelTransport.Name = "labelTransport";
            labelTransport.Size = new Size(69, 21);
            labelTransport.TabIndex = 53;
            labelTransport.Text = "Doprava";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnd.Location = new Point(39, 287);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(140, 21);
            labelEnd.TabIndex = 52;
            labelEnd.Text = "Dátum a čas konca";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStart.Location = new Point(39, 243);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(155, 21);
            labelStart.TabIndex = 51;
            labelStart.Text = "Dátum a čas začiatku";
            // 
            // labelFinalCity
            // 
            labelFinalCity.AutoSize = true;
            labelFinalCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFinalCity.Location = new Point(39, 197);
            labelFinalCity.Name = "labelFinalCity";
            labelFinalCity.Size = new Size(132, 21);
            labelFinalCity.TabIndex = 50;
            labelFinalCity.Text = "Koniec prac. cesty";
            // 
            // labelStartCity
            // 
            labelStartCity.AutoSize = true;
            labelStartCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStartCity.Location = new Point(39, 150);
            labelStartCity.Name = "labelStartCity";
            labelStartCity.Size = new Size(144, 21);
            labelStartCity.TabIndex = 49;
            labelStartCity.Text = "Začiatok prac. cesty";
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployee.Location = new Point(39, 100);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(102, 21);
            labelEmployee.TabIndex = 48;
            labelEmployee.Text = "Zamestnanec";
            // 
            // checkedListBoxTransport
            // 
            checkedListBoxTransport.Enabled = false;
            checkedListBoxTransport.FormattingEnabled = true;
            checkedListBoxTransport.Items.AddRange(new object[] { "Služobné auto", "Autobus", "MHD", "Pešo", "Vlak", "Taxi", "Lietadlo" });
            checkedListBoxTransport.Location = new Point(213, 334);
            checkedListBoxTransport.Name = "checkedListBoxTransport";
            checkedListBoxTransport.Size = new Size(199, 130);
            checkedListBoxTransport.TabIndex = 47;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(213, 543);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(74, 23);
            buttonConfirm.TabIndex = 46;
            buttonConfirm.Text = "Vymaž";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // removeTravelOrder
            // 
            removeTravelOrder.AutoSize = true;
            removeTravelOrder.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            removeTravelOrder.Location = new Point(30, 9);
            removeTravelOrder.Name = "removeTravelOrder";
            removeTravelOrder.Size = new Size(272, 25);
            removeTravelOrder.TabIndex = 45;
            removeTravelOrder.Text = "Vymazanie cestovného príkazu";
            // 
            // comboBoxState
            // 
            comboBoxState.DisplayMember = "Id";
            comboBoxState.Enabled = false;
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(213, 486);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(199, 23);
            comboBoxState.TabIndex = 44;
            comboBoxState.ValueMember = "Id";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Enabled = false;
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(213, 287);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(199, 23);
            dateTimePickerEnd.TabIndex = 43;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Enabled = false;
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(213, 241);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(199, 23);
            dateTimePickerStart.TabIndex = 42;
            // 
            // comboBoxFinalCity
            // 
            comboBoxFinalCity.DisplayMember = "Id";
            comboBoxFinalCity.Enabled = false;
            comboBoxFinalCity.FormattingEnabled = true;
            comboBoxFinalCity.Location = new Point(213, 195);
            comboBoxFinalCity.Name = "comboBoxFinalCity";
            comboBoxFinalCity.Size = new Size(199, 23);
            comboBoxFinalCity.TabIndex = 41;
            comboBoxFinalCity.ValueMember = "Id";
            // 
            // comboBoxStartCity
            // 
            comboBoxStartCity.DisplayMember = "Id";
            comboBoxStartCity.Enabled = false;
            comboBoxStartCity.FormattingEnabled = true;
            comboBoxStartCity.Location = new Point(213, 148);
            comboBoxStartCity.Name = "comboBoxStartCity";
            comboBoxStartCity.Size = new Size(199, 23);
            comboBoxStartCity.TabIndex = 40;
            comboBoxStartCity.ValueMember = "Id";
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.DisplayMember = "Id";
            comboBoxEmployee.Enabled = false;
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(213, 100);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(289, 23);
            comboBoxEmployee.TabIndex = 39;
            comboBoxEmployee.ValueMember = "Id";
            // 
            // DeleteTravelOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 656);
            Controls.Add(state);
            Controls.Add(labelTransport);
            Controls.Add(labelEnd);
            Controls.Add(labelStart);
            Controls.Add(labelFinalCity);
            Controls.Add(labelStartCity);
            Controls.Add(labelEmployee);
            Controls.Add(checkedListBoxTransport);
            Controls.Add(buttonConfirm);
            Controls.Add(removeTravelOrder);
            Controls.Add(comboBoxState);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(comboBoxFinalCity);
            Controls.Add(comboBoxStartCity);
            Controls.Add(comboBoxEmployee);
            Name = "DeleteTravelOrder";
            Text = "DeleteTravelOrder";
            Load += DeleteTravelOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label state;
        private Label labelTransport;
        private Label labelEnd;
        private Label labelStart;
        private Label labelFinalCity;
        private Label labelStartCity;
        private Label labelEmployee;
        private CheckedListBox checkedListBoxTransport;
        private Button buttonConfirm;
        private Label removeTravelOrder;
        private ComboBox comboBoxState;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private ComboBox comboBoxFinalCity;
        private ComboBox comboBoxStartCity;
        private ComboBox comboBoxEmployee;
    }
}