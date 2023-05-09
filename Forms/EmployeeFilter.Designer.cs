namespace CestovnePrikazy.Forms
{
    partial class EmployeeFilter
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
            employeeFltr = new Label();
            comboBoxEmployee = new ComboBox();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // employeeFltr
            // 
            employeeFltr.AutoSize = true;
            employeeFltr.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            employeeFltr.Location = new Point(30, 9);
            employeeFltr.Name = "employeeFltr";
            employeeFltr.Size = new Size(233, 25);
            employeeFltr.TabIndex = 50;
            employeeFltr.Text = "Filter - výber zamestnanca";
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.DisplayMember = "Id";
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(30, 57);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(289, 23);
            comboBoxEmployee.TabIndex = 49;
            comboBoxEmployee.ValueMember = "Id";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(30, 108);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(74, 23);
            buttonConfirm.TabIndex = 52;
            buttonConfirm.Text = "Potvrď";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // EmployeeFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 154);
            Controls.Add(buttonConfirm);
            Controls.Add(employeeFltr);
            Controls.Add(comboBoxEmployee);
            Name = "EmployeeFilter";
            Text = "EmployeeFilter";
            Load += EmployeeFilter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label employeeFltr;
        private ComboBox comboBoxEmployee;
        private Button buttonConfirm;
    }
}