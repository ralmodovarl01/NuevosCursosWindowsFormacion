namespace NuevosCursosWindowsFormacion
{
    partial class FormAlumnos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_AlumnoLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cursoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnos));
            this.gcfd = new NuevosCursosWindowsFormacion.gcfd();
            this.aLUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMNOSTableAdapter = new NuevosCursosWindowsFormacion.gcfdTableAdapters.ALUMNOSTableAdapter();
            this.tableAdapterManager = new NuevosCursosWindowsFormacion.gcfdTableAdapters.TableAdapterManager();
            this.aLUMNOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aLUMNOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_AlumnoTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cursoComboBox = new System.Windows.Forms.ComboBox();
            id_AlumnoLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcfd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingNavigator)).BeginInit();
            this.aLUMNOSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_AlumnoLabel
            // 
            id_AlumnoLabel.AutoSize = true;
            id_AlumnoLabel.Location = new System.Drawing.Point(120, 100);
            id_AlumnoLabel.Name = "id_AlumnoLabel";
            id_AlumnoLabel.Size = new System.Drawing.Size(69, 16);
            id_AlumnoLabel.TabIndex = 1;
            id_AlumnoLabel.Text = "Id Alumno:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(120, 140);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(30, 16);
            dniLabel.TabIndex = 3;
            dniLabel.Text = "Dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(120, 194);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(122, 244);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(67, 16);
            apellidosLabel.TabIndex = 7;
            apellidosLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(122, 310);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(120, 392);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(45, 16);
            cursoLabel.TabIndex = 11;
            cursoLabel.Text = "Curso:";
            // 
            // gcfd
            // 
            this.gcfd.DataSetName = "gcfd";
            this.gcfd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMNOSBindingSource
            // 
            this.aLUMNOSBindingSource.DataMember = "ALUMNOS";
            this.aLUMNOSBindingSource.DataSource = this.gcfd;
            // 
            // aLUMNOSTableAdapter
            // 
            this.aLUMNOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNOSTableAdapter = this.aLUMNOSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CURSOSTableAdapter = null;
            this.tableAdapterManager.ESTADOSTableAdapter = null;
            this.tableAdapterManager.FAMILIASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NuevosCursosWindowsFormacion.gcfdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aLUMNOSBindingNavigator
            // 
            this.aLUMNOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aLUMNOSBindingNavigator.BindingSource = this.aLUMNOSBindingSource;
            this.aLUMNOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aLUMNOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aLUMNOSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aLUMNOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aLUMNOSBindingNavigatorSaveItem});
            this.aLUMNOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aLUMNOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aLUMNOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aLUMNOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aLUMNOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aLUMNOSBindingNavigator.Name = "aLUMNOSBindingNavigator";
            this.aLUMNOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aLUMNOSBindingNavigator.Size = new System.Drawing.Size(1183, 27);
            this.aLUMNOSBindingNavigator.TabIndex = 0;
            this.aLUMNOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // aLUMNOSBindingNavigatorSaveItem
            // 
            this.aLUMNOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aLUMNOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aLUMNOSBindingNavigatorSaveItem.Image")));
            this.aLUMNOSBindingNavigatorSaveItem.Name = "aLUMNOSBindingNavigatorSaveItem";
            this.aLUMNOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.aLUMNOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.aLUMNOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.aLUMNOSBindingNavigatorSaveItem_Click);
            // 
            // id_AlumnoTextBox
            // 
            this.id_AlumnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Id_Alumno", true));
            this.id_AlumnoTextBox.Location = new System.Drawing.Point(195, 94);
            this.id_AlumnoTextBox.Name = "id_AlumnoTextBox";
            this.id_AlumnoTextBox.Size = new System.Drawing.Size(346, 22);
            this.id_AlumnoTextBox.TabIndex = 2;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(195, 140);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(346, 22);
            this.dniTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(195, 188);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(346, 22);
            this.nombreTextBox.TabIndex = 6;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(195, 238);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(346, 22);
            this.apellidosTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(195, 304);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(346, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // cursoComboBox
            // 
            this.cursoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Curso", true));
            this.cursoComboBox.FormattingEnabled = true;
            this.cursoComboBox.Location = new System.Drawing.Point(195, 384);
            this.cursoComboBox.Name = "cursoComboBox";
            this.cursoComboBox.Size = new System.Drawing.Size(346, 24);
            this.cursoComboBox.TabIndex = 12;
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 469);
            this.Controls.Add(id_AlumnoLabel);
            this.Controls.Add(this.id_AlumnoTextBox);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoComboBox);
            this.Controls.Add(this.aLUMNOSBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlumnos";
            this.Text = "FormAlumnos";
            this.Load += new System.EventHandler(this.FormAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcfd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingNavigator)).EndInit();
            this.aLUMNOSBindingNavigator.ResumeLayout(false);
            this.aLUMNOSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gcfd gcfd;
        private System.Windows.Forms.BindingSource aLUMNOSBindingSource;
        private gcfdTableAdapters.ALUMNOSTableAdapter aLUMNOSTableAdapter;
        private gcfdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aLUMNOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aLUMNOSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_AlumnoTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox cursoComboBox;
    }
}