using CestovnePrikazy.CQR.Queries;
using System.Data;
using System.Diagnostics;

namespace CestovnePrikazy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemTable = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            startCity = new DataGridViewTextBoxColumn();
            finalCity = new DataGridViewTextBoxColumn();
            startDateTime = new DataGridViewTextBoxColumn();
            endDateTime = new DataGridViewTextBoxColumn();
            travelOrderState = new DataGridViewTextBoxColumn();
            editBtn = new DataGridViewButtonColumn();
            deleteBtn = new DataGridViewButtonColumn();
            title = new Label();
            newRecord = new Button();
            filter = new Button();
            ((System.ComponentModel.ISupportInitialize)itemTable).BeginInit();
            SuspendLayout();
            // 
            // itemTable
            // 
            itemTable.AutoGenerateColumns = false;
            itemTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemTable.Columns.AddRange(new DataGridViewColumn[] { id, name, surname, startCity, finalCity, startDateTime, endDateTime, travelOrderState, editBtn, deleteBtn });
            itemTable.Location = new Point(43, 120);
            itemTable.Name = "itemTable";
            itemTable.RowTemplate.Height = 25;
            itemTable.Size = new Size(1368, 495);
            itemTable.TabIndex = 3;
            itemTable.CellClick += itemTable_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 5;
            // 
            // name
            // 
            name.DataPropertyName = "EmployeeName";
            name.HeaderText = "Meno";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 140;
            // 
            // surname
            // 
            surname.DataPropertyName = "Surname";
            surname.HeaderText = "Priezvisko";
            surname.Name = "surname";
            surname.ReadOnly = true;
            surname.Width = 140;
            // 
            // startCity
            // 
            startCity.DataPropertyName = "StartCityCountry";
            startCity.HeaderText = "Miesto začiatku prac. cesty";
            startCity.Name = "startCity";
            startCity.ReadOnly = true;
            startCity.Width = 175;
            // 
            // finalCity
            // 
            finalCity.DataPropertyName = "FinalCityCountry";
            finalCity.HeaderText = "Miesto konca prac. cesty";
            finalCity.Name = "finalCity";
            finalCity.ReadOnly = true;
            finalCity.Width = 175;
            // 
            // startDateTime
            // 
            startDateTime.DataPropertyName = "StartDateTime";
            startDateTime.HeaderText = "Dátum a čas začiatku pr. c.";
            startDateTime.Name = "startDateTime";
            startDateTime.ReadOnly = true;
            startDateTime.Width = 175;
            // 
            // endDateTime
            // 
            endDateTime.DataPropertyName = "EndDateTime";
            endDateTime.HeaderText = "Dátum a čas konca pr. c.";
            endDateTime.Name = "endDateTime";
            endDateTime.ReadOnly = true;
            endDateTime.Width = 175;
            // 
            // travelOrderState
            // 
            travelOrderState.DataPropertyName = "TravelRecordState";
            travelOrderState.HeaderText = "Stav";
            travelOrderState.Name = "travelOrderState";
            travelOrderState.Width = 75;
            // 
            // editBtn
            // 
            editBtn.HeaderText = "Uprav";
            editBtn.Name = "editBtn";
            editBtn.Text = "Uprav";
            editBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteBtn
            // 
            deleteBtn.HeaderText = "Vymaž";
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Text = "Vymaž";
            deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(22, 22);
            title.Name = "title";
            title.Size = new Size(210, 21);
            title.TabIndex = 0;
            title.Text = "Zoznam cestovných príkazov";
            // 
            // newRecord
            // 
            newRecord.Location = new Point(1224, 91);
            newRecord.Name = "newRecord";
            newRecord.Size = new Size(113, 23);
            newRecord.TabIndex = 5;
            newRecord.Text = "Nový cest. príkaz";
            newRecord.UseVisualStyleBackColor = true;
            newRecord.Click += newRecord_Click;
            // 
            // filter
            // 
            filter.Location = new Point(43, 70);
            filter.Name = "filter";
            filter.Size = new Size(79, 44);
            filter.TabIndex = 6;
            filter.Text = "Filter podľa zmestnanca";
            filter.UseVisualStyleBackColor = true;
            filter.Click += filter_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 635);
            Controls.Add(filter);
            Controls.Add(newRecord);
            Controls.Add(itemTable);
            Controls.Add(title);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)itemTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private DataGridView itemTable;
        private Button newRecord;
        private Button filter;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn startCity;
        private DataGridViewTextBoxColumn finalCity;
        private DataGridViewTextBoxColumn startDateTime;
        private DataGridViewTextBoxColumn endDateTime;
        private DataGridViewTextBoxColumn travelOrderState;
        private DataGridViewButtonColumn editBtn;
        private DataGridViewButtonColumn deleteBtn;
    }
}