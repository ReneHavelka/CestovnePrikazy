namespace CestovnePrikazy.Forms
{
    partial class CreateTravelOrder
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
            comboBoxEmployee = new ComboBox();
            comboBoxStartCity = new ComboBox();
            comboBoxFinalCity = new ComboBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            comboBoxState = new ComboBox();
            newTravelOrder = new Label();
            buttonConfirm = new Button();
            checkedListBoxTransport = new CheckedListBox();
            labelEmployee = new Label();
            labelStartCity = new Label();
            labelFinalCity = new Label();
            labelStart = new Label();
            labelEnd = new Label();
            labelTransport = new Label();
            state = new Label();
            ex_messageEmployee = new Label();
            ex_EndDateTimeMsg = new Label();
            ex_startCityMsg = new Label();
            ex_finalCityMsg = new Label();
            SuspendLayout();
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.DisplayMember = "Id";
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(213, 100);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(290, 23);
            comboBoxEmployee.TabIndex = 0;
            comboBoxEmployee.ValueMember = "Id";
            comboBoxEmployee.SelectedIndexChanged += comboBoxEmployee_SelectedIndexChanged;
            // 
            // comboBoxStartCity
            // 
            comboBoxStartCity.DisplayMember = "Id";
            comboBoxStartCity.FormattingEnabled = true;
            comboBoxStartCity.Location = new Point(213, 148);
            comboBoxStartCity.Name = "comboBoxStartCity";
            comboBoxStartCity.Size = new Size(200, 23);
            comboBoxStartCity.TabIndex = 1;
            comboBoxStartCity.ValueMember = "Id";
            comboBoxStartCity.SelectedIndexChanged += comboBoxStartCity_SelectedIndexChanged;
            // 
            // comboBoxFinalCity
            // 
            comboBoxFinalCity.DisplayMember = "Id";
            comboBoxFinalCity.FormattingEnabled = true;
            comboBoxFinalCity.Location = new Point(213, 195);
            comboBoxFinalCity.Name = "comboBoxFinalCity";
            comboBoxFinalCity.Size = new Size(200, 23);
            comboBoxFinalCity.TabIndex = 2;
            comboBoxFinalCity.ValueMember = "Id";
            comboBoxFinalCity.SelectedIndexChanged += comboBoxFinalCity_SelectedIndexChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(213, 241);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 3;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(213, 287);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 4;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // comboBoxState
            // 
            comboBoxState.DisplayMember = "Id";
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(213, 486);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(200, 23);
            comboBoxState.TabIndex = 12;
            comboBoxState.ValueMember = "Id";
            comboBoxState.SelectedIndexChanged += comboBoxState_SelectedIndexChanged;
            // 
            // newTravelOrder
            // 
            newTravelOrder.AutoSize = true;
            newTravelOrder.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            newTravelOrder.Location = new Point(30, 9);
            newTravelOrder.Name = "newTravelOrder";
            newTravelOrder.Size = new Size(189, 25);
            newTravelOrder.TabIndex = 13;
            newTravelOrder.Text = "Nový cestovný príkaz";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(213, 543);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 23);
            buttonConfirm.TabIndex = 14;
            buttonConfirm.Text = "Potvrď";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // checkedListBoxTransport
            // 
            checkedListBoxTransport.FormattingEnabled = true;
            checkedListBoxTransport.Items.AddRange(new object[] { "Služobné auto", "Autobus", "MHD", "Pešo", "Vlak", "Taxi", "Lietadlo" });
            checkedListBoxTransport.Location = new Point(213, 334);
            checkedListBoxTransport.Name = "checkedListBoxTransport";
            checkedListBoxTransport.Size = new Size(200, 130);
            checkedListBoxTransport.TabIndex = 15;
            checkedListBoxTransport.Leave += checkedListBoxTransport_Leave;
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployee.Location = new Point(30, 100);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(102, 21);
            labelEmployee.TabIndex = 16;
            labelEmployee.Text = "Zamestnanec";
            // 
            // labelStartCity
            // 
            labelStartCity.AutoSize = true;
            labelStartCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStartCity.Location = new Point(30, 150);
            labelStartCity.Name = "labelStartCity";
            labelStartCity.Size = new Size(144, 21);
            labelStartCity.TabIndex = 17;
            labelStartCity.Text = "Začiatok prac. cesty";
            // 
            // labelFinalCity
            // 
            labelFinalCity.AutoSize = true;
            labelFinalCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFinalCity.Location = new Point(30, 197);
            labelFinalCity.Name = "labelFinalCity";
            labelFinalCity.Size = new Size(132, 21);
            labelFinalCity.TabIndex = 18;
            labelFinalCity.Text = "Koniec prac. cesty";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStart.Location = new Point(30, 243);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(155, 21);
            labelStart.TabIndex = 19;
            labelStart.Text = "Dátum a čas začiatku";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnd.Location = new Point(30, 287);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(140, 21);
            labelEnd.TabIndex = 20;
            labelEnd.Text = "Dátum a čas konca";
            // 
            // labelTransport
            // 
            labelTransport.AutoSize = true;
            labelTransport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTransport.Location = new Point(33, 334);
            labelTransport.Name = "labelTransport";
            labelTransport.Size = new Size(69, 21);
            labelTransport.TabIndex = 21;
            labelTransport.Text = "Doprava";
            // 
            // state
            // 
            state.AutoSize = true;
            state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            state.Location = new Point(33, 488);
            state.Name = "state";
            state.Size = new Size(39, 21);
            state.TabIndex = 22;
            state.Text = "Stav";
            // 
            // ex_messageEmployee
            // 
            ex_messageEmployee.AutoSize = true;
            ex_messageEmployee.ForeColor = Color.Red;
            ex_messageEmployee.Location = new Point(520, 105);
            ex_messageEmployee.Name = "ex_messageEmployee";
            ex_messageEmployee.Size = new Size(76, 15);
            ex_messageEmployee.TabIndex = 23;
            ex_messageEmployee.Text = "Povinný údaj";
            ex_messageEmployee.Visible = false;
            // 
            // ex_EndDateTimeMsg
            // 
            ex_EndDateTimeMsg.AutoSize = true;
            ex_EndDateTimeMsg.ForeColor = Color.Red;
            ex_EndDateTimeMsg.Location = new Point(430, 292);
            ex_EndDateTimeMsg.Name = "ex_EndDateTimeMsg";
            ex_EndDateTimeMsg.Size = new Size(269, 15);
            ex_EndDateTimeMsg.TabIndex = 24;
            ex_EndDateTimeMsg.Text = "Koniec prac. cesty musí byť neskorší ako začiatok.";
            ex_EndDateTimeMsg.Visible = false;
            // 
            // ex_startCityMsg
            // 
            ex_startCityMsg.AutoSize = true;
            ex_startCityMsg.ForeColor = Color.Red;
            ex_startCityMsg.Location = new Point(430, 151);
            ex_startCityMsg.Name = "ex_startCityMsg";
            ex_startCityMsg.Size = new Size(76, 15);
            ex_startCityMsg.TabIndex = 25;
            ex_startCityMsg.Text = "Povinný údaj";
            ex_startCityMsg.Visible = false;
            // 
            // ex_finalCityMsg
            // 
            ex_finalCityMsg.AutoSize = true;
            ex_finalCityMsg.ForeColor = Color.Red;
            ex_finalCityMsg.Location = new Point(430, 198);
            ex_finalCityMsg.Name = "ex_finalCityMsg";
            ex_finalCityMsg.Size = new Size(76, 15);
            ex_finalCityMsg.TabIndex = 26;
            ex_finalCityMsg.Text = "Povinný údaj";
            ex_finalCityMsg.Visible = false;
            // 
            // CreateTravelOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 656);
            Controls.Add(ex_finalCityMsg);
            Controls.Add(ex_startCityMsg);
            Controls.Add(ex_EndDateTimeMsg);
            Controls.Add(ex_messageEmployee);
            Controls.Add(state);
            Controls.Add(labelTransport);
            Controls.Add(labelEnd);
            Controls.Add(labelStart);
            Controls.Add(labelFinalCity);
            Controls.Add(labelStartCity);
            Controls.Add(labelEmployee);
            Controls.Add(checkedListBoxTransport);
            Controls.Add(buttonConfirm);
            Controls.Add(newTravelOrder);
            Controls.Add(comboBoxState);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(comboBoxFinalCity);
            Controls.Add(comboBoxStartCity);
            Controls.Add(comboBoxEmployee);
            Name = "CreateTravelOrder";
            Text = "NewTravelOrder";
            Load += CreateTravelOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEmployee;
        private ComboBox comboBoxStartCity;
        private ComboBox comboBoxFinalCity;
        private DateTimePicker dateTimePickerStart;
        private ComboBox comboBoxState;
        private Label newTravelOrder;
        private Button buttonConfirm;
        private DateTimePicker dateTimePickerEnd;
        private CheckedListBox checkedListBoxTransport;
        private Label labelEmployee;
        private Label labelStartCity;
        private Label labelFinalCity;
        private Label labelStart;
        private Label labelEnd;
        private Label labelTransport;
        private Label state;
        private Label ex_messageEmployee;
        private Label ex_EndDateTimeMsg;
        private Label ex_startCityMsg;
        private Label ex_finalCityMsg;
    }
}