namespace CestovnePrikazy.Forms
{
    partial class EditTravelOrder
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
            updateTravelOrder = new Label();
            comboBoxState = new ComboBox();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            comboBoxFinalCity = new ComboBox();
            comboBoxStartCity = new ComboBox();
            comboBoxEmployee = new ComboBox();
            ex_EndDateTimeMsg = new Label();
            SuspendLayout();
            // 
            // state
            // 
            state.AutoSize = true;
            state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            state.Location = new Point(33, 488);
            state.Name = "state";
            state.Size = new Size(39, 21);
            state.TabIndex = 38;
            state.Text = "Stav";
            // 
            // labelTransport
            // 
            labelTransport.AutoSize = true;
            labelTransport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTransport.Location = new Point(33, 334);
            labelTransport.Name = "labelTransport";
            labelTransport.Size = new Size(69, 21);
            labelTransport.TabIndex = 37;
            labelTransport.Text = "Doprava";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnd.Location = new Point(30, 287);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(140, 21);
            labelEnd.TabIndex = 36;
            labelEnd.Text = "Dátum a čas konca";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStart.Location = new Point(30, 243);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(155, 21);
            labelStart.TabIndex = 35;
            labelStart.Text = "Dátum a čas začiatku";
            // 
            // labelFinalCity
            // 
            labelFinalCity.AutoSize = true;
            labelFinalCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFinalCity.Location = new Point(30, 197);
            labelFinalCity.Name = "labelFinalCity";
            labelFinalCity.Size = new Size(132, 21);
            labelFinalCity.TabIndex = 34;
            labelFinalCity.Text = "Koniec prac. cesty";
            // 
            // labelStartCity
            // 
            labelStartCity.AutoSize = true;
            labelStartCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStartCity.Location = new Point(30, 150);
            labelStartCity.Name = "labelStartCity";
            labelStartCity.Size = new Size(144, 21);
            labelStartCity.TabIndex = 33;
            labelStartCity.Text = "Začiatok prac. cesty";
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployee.Location = new Point(30, 100);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(102, 21);
            labelEmployee.TabIndex = 32;
            labelEmployee.Text = "Zamestnanec";
            // 
            // checkedListBoxTransport
            // 
            checkedListBoxTransport.FormattingEnabled = true;
            checkedListBoxTransport.Items.AddRange(new object[] { "Služobné auto", "Autobus", "MHD", "Pešo", "Vlak", "Taxi", "Lietadlo" });
            checkedListBoxTransport.Location = new Point(213, 334);
            checkedListBoxTransport.Name = "checkedListBoxTransport";
            checkedListBoxTransport.Size = new Size(200, 130);
            checkedListBoxTransport.TabIndex = 31;
            checkedListBoxTransport.Leave += checkedListBoxTransport_Leave;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(213, 543);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 23);
            buttonConfirm.TabIndex = 30;
            buttonConfirm.Text = "Potvrď";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // updateTravelOrder
            // 
            updateTravelOrder.AutoSize = true;
            updateTravelOrder.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updateTravelOrder.Location = new Point(30, 9);
            updateTravelOrder.Name = "updateTravelOrder";
            updateTravelOrder.Size = new Size(144, 25);
            updateTravelOrder.TabIndex = 29;
            updateTravelOrder.Text = "Cestovný príkaz";
            // 
            // comboBoxState
            // 
            comboBoxState.DisplayMember = "Id";
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(213, 486);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(200, 23);
            comboBoxState.TabIndex = 28;
            comboBoxState.ValueMember = "Id";
            comboBoxState.SelectedIndexChanged += comboBoxState_SelectedIndexChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(213, 287);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 27;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(213, 241);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 26;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // comboBoxFinalCity
            // 
            comboBoxFinalCity.DisplayMember = "Id";
            comboBoxFinalCity.FormattingEnabled = true;
            comboBoxFinalCity.Location = new Point(213, 195);
            comboBoxFinalCity.Name = "comboBoxFinalCity";
            comboBoxFinalCity.Size = new Size(200, 23);
            comboBoxFinalCity.TabIndex = 25;
            comboBoxFinalCity.ValueMember = "Id";
            comboBoxFinalCity.SelectedIndexChanged += comboBoxFinalCity_SelectedIndexChanged;
            // 
            // comboBoxStartCity
            // 
            comboBoxStartCity.DisplayMember = "Id";
            comboBoxStartCity.FormattingEnabled = true;
            comboBoxStartCity.Location = new Point(213, 148);
            comboBoxStartCity.Name = "comboBoxStartCity";
            comboBoxStartCity.Size = new Size(200, 23);
            comboBoxStartCity.TabIndex = 24;
            comboBoxStartCity.ValueMember = "Id";
            comboBoxStartCity.SelectedIndexChanged += comboBoxStartCity_SelectedIndexChanged;
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.DisplayMember = "Id";
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(213, 100);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(290, 23);
            comboBoxEmployee.TabIndex = 23;
            comboBoxEmployee.ValueMember = "Id";
            comboBoxEmployee.SelectedIndexChanged += comboBoxEmployee_SelectedIndexChanged;
            // 
            // ex_EndDateTimeMsg
            // 
            ex_EndDateTimeMsg.AutoSize = true;
            ex_EndDateTimeMsg.ForeColor = Color.Red;
            ex_EndDateTimeMsg.Location = new Point(430, 295);
            ex_EndDateTimeMsg.Name = "ex_EndDateTimeMsg";
            ex_EndDateTimeMsg.Size = new Size(269, 15);
            ex_EndDateTimeMsg.TabIndex = 39;
            ex_EndDateTimeMsg.Text = "Koniec prac. cesty musí byť neskorší ako začiatok.";
            ex_EndDateTimeMsg.Visible = false;
            // 
            // EditTravelOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 656);
            Controls.Add(ex_EndDateTimeMsg);
            Controls.Add(state);
            Controls.Add(labelTransport);
            Controls.Add(labelEnd);
            Controls.Add(labelStart);
            Controls.Add(labelFinalCity);
            Controls.Add(labelStartCity);
            Controls.Add(labelEmployee);
            Controls.Add(checkedListBoxTransport);
            Controls.Add(buttonConfirm);
            Controls.Add(updateTravelOrder);
            Controls.Add(comboBoxState);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(comboBoxFinalCity);
            Controls.Add(comboBoxStartCity);
            Controls.Add(comboBoxEmployee);
            Name = "EditTravelOrder";
            Text = "EditTravelOrder";
            Load += EditTravelOrder_Load;
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
        private Label updateTravelOrder;
        private ComboBox comboBoxState;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private ComboBox comboBoxFinalCity;
        private ComboBox comboBoxStartCity;
        private ComboBox comboBoxEmployee;
        private Label ex_EndDateTimeMsg;
    }
}