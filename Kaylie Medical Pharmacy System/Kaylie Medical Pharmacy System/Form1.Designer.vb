<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DateofBirthLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim Physical_addressLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim AffectionLabel As System.Windows.Forms.Label
        Dim DrugsLabel As System.Windows.Forms.Label
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim SurnameLabel1 As System.Windows.Forms.Label
        Dim GenderLabel1 As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim National_IDLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Drug_IDLabel As System.Windows.Forms.Label
        Dim Drug_NameLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Dim Supplier_ContactLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PharmacyDataSet = New Kaylie_Medical_Pharmacy_System.PharmacyDataSet()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.PatientsTableAdapter()
        Me.TableAdapterManager = New Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.TableAdapterManager()
        Me.PatientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PatientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PatientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.DateofBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.Physical_addressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.AffectionTextBox = New System.Windows.Forms.TextBox()
        Me.DrugsTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.EmployeesTableAdapter()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.GenderTextBox1 = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.National_IDTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrugsTableAdapter = New Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.DrugsTableAdapter()
        Me.Drug_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Drug_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_ContactTextBox = New System.Windows.Forms.TextBox()
        Me.DrugsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Patient_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DateofBirthLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        Physical_addressLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        AffectionLabel = New System.Windows.Forms.Label()
        DrugsLabel = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        SurnameLabel1 = New System.Windows.Forms.Label()
        GenderLabel1 = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        National_IDLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Drug_IDLabel = New System.Windows.Forms.Label()
        Drug_NameLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        Supplier_ContactLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientsBindingNavigator.SuspendLayout()
        CType(Me.PatientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 3)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(822, 530)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(814, 499)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main Menu"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Patient_IDLabel)
        Me.TabPage2.Controls.Add(Me.Patient_IDTextBox)
        Me.TabPage2.Controls.Add(NameLabel)
        Me.TabPage2.Controls.Add(Me.NameTextBox)
        Me.TabPage2.Controls.Add(SurnameLabel)
        Me.TabPage2.Controls.Add(Me.SurnameTextBox)
        Me.TabPage2.Controls.Add(GenderLabel)
        Me.TabPage2.Controls.Add(Me.GenderTextBox)
        Me.TabPage2.Controls.Add(DateofBirthLabel)
        Me.TabPage2.Controls.Add(Me.DateofBirthDateTimePicker)
        Me.TabPage2.Controls.Add(OccupationLabel)
        Me.TabPage2.Controls.Add(Me.OccupationTextBox)
        Me.TabPage2.Controls.Add(Physical_addressLabel)
        Me.TabPage2.Controls.Add(Me.Physical_addressTextBox)
        Me.TabPage2.Controls.Add(ContactLabel)
        Me.TabPage2.Controls.Add(Me.ContactTextBox)
        Me.TabPage2.Controls.Add(AffectionLabel)
        Me.TabPage2.Controls.Add(Me.AffectionTextBox)
        Me.TabPage2.Controls.Add(DrugsLabel)
        Me.TabPage2.Controls.Add(Me.DrugsTextBox)
        Me.TabPage2.Controls.Add(Me.PatientsBindingNavigator)
        Me.TabPage2.Controls.Add(Me.PatientsDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(814, 499)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Patients"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button9)
        Me.TabPage3.Controls.Add(Me.Button10)
        Me.TabPage3.Controls.Add(Me.Button11)
        Me.TabPage3.Controls.Add(Me.Button12)
        Me.TabPage3.Controls.Add(Me.Button13)
        Me.TabPage3.Controls.Add(Me.EmployeesDataGridView)
        Me.TabPage3.Controls.Add(Employee_IDLabel)
        Me.TabPage3.Controls.Add(Me.Employee_IDTextBox)
        Me.TabPage3.Controls.Add(NameLabel1)
        Me.TabPage3.Controls.Add(Me.NameTextBox1)
        Me.TabPage3.Controls.Add(SurnameLabel1)
        Me.TabPage3.Controls.Add(Me.SurnameTextBox1)
        Me.TabPage3.Controls.Add(GenderLabel1)
        Me.TabPage3.Controls.Add(Me.GenderTextBox1)
        Me.TabPage3.Controls.Add(DepartmentLabel)
        Me.TabPage3.Controls.Add(Me.DepartmentTextBox)
        Me.TabPage3.Controls.Add(National_IDLabel)
        Me.TabPage3.Controls.Add(Me.National_IDTextBox)
        Me.TabPage3.Controls.Add(AddressLabel)
        Me.TabPage3.Controls.Add(Me.AddressTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Size = New System.Drawing.Size(814, 499)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Employees"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button8)
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.DrugsDataGridView)
        Me.TabPage4.Controls.Add(Drug_IDLabel)
        Me.TabPage4.Controls.Add(Me.Drug_IDTextBox)
        Me.TabPage4.Controls.Add(Drug_NameLabel)
        Me.TabPage4.Controls.Add(Me.Drug_NameTextBox)
        Me.TabPage4.Controls.Add(CategoryLabel)
        Me.TabPage4.Controls.Add(Me.CategoryTextBox)
        Me.TabPage4.Controls.Add(PriceLabel)
        Me.TabPage4.Controls.Add(Me.PriceTextBox)
        Me.TabPage4.Controls.Add(SupplierLabel)
        Me.TabPage4.Controls.Add(Me.SupplierTextBox)
        Me.TabPage4.Controls.Add(Supplier_ContactLabel)
        Me.TabPage4.Controls.Add(Me.Supplier_ContactTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage4.Size = New System.Drawing.Size(814, 499)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Drugs"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 72)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(40, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 72)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(40, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 72)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PharmacyDataSet
        '
        Me.PharmacyDataSet.DataSetName = "PharmacyDataSet"
        Me.PharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.PharmacyDataSet
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DrugsTableAdapter = Me.DrugsTableAdapter
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.PatientsTableAdapter = Me.PatientsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PatientsBindingNavigator
        '
        Me.PatientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PatientsBindingNavigator.BindingSource = Me.PatientsBindingSource
        Me.PatientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PatientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PatientsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PatientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PatientsBindingNavigatorSaveItem})
        Me.PatientsBindingNavigator.Location = New System.Drawing.Point(204, 226)
        Me.PatientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PatientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PatientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PatientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PatientsBindingNavigator.Name = "PatientsBindingNavigator"
        Me.PatientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PatientsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.PatientsBindingNavigator.TabIndex = 1
        Me.PatientsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PatientsBindingNavigatorSaveItem
        '
        Me.PatientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PatientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("PatientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PatientsBindingNavigatorSaveItem.Name = "PatientsBindingNavigatorSaveItem"
        Me.PatientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PatientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PatientsDataGridView
        '
        Me.PatientsDataGridView.AutoGenerateColumns = False
        Me.PatientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.PatientsDataGridView.DataSource = Me.PatientsBindingSource
        Me.PatientsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.PatientsDataGridView.Name = "PatientsDataGridView"
        Me.PatientsDataGridView.Size = New System.Drawing.Size(808, 220)
        Me.PatientsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateofBirth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DateofBirth"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Occupation"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Occupation"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Physical address"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Physical address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Contact"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Affection"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Affection"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Drugs"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Drugs"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Location = New System.Drawing.Point(23, 268)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(74, 18)
        Patient_IDLabel.TabIndex = 2
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(134, 265)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Patient_IDTextBox.TabIndex = 3
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(23, 299)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(45, 18)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(134, 296)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 25)
        Me.NameTextBox.TabIndex = 5
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(23, 330)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(61, 18)
        SurnameLabel.TabIndex = 6
        SurnameLabel.Text = "Surname:"
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(134, 327)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 25)
        Me.SurnameTextBox.TabIndex = 7
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(23, 361)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(54, 18)
        GenderLabel.TabIndex = 8
        GenderLabel.Text = "Gender:"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(134, 358)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 25)
        Me.GenderTextBox.TabIndex = 9
        '
        'DateofBirthLabel
        '
        DateofBirthLabel.AutoSize = True
        DateofBirthLabel.Location = New System.Drawing.Point(23, 393)
        DateofBirthLabel.Name = "DateofBirthLabel"
        DateofBirthLabel.Size = New System.Drawing.Size(86, 18)
        DateofBirthLabel.TabIndex = 10
        DateofBirthLabel.Text = "Dateof Birth:"
        '
        'DateofBirthDateTimePicker
        '
        Me.DateofBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientsBindingSource, "DateofBirth", True))
        Me.DateofBirthDateTimePicker.Location = New System.Drawing.Point(134, 389)
        Me.DateofBirthDateTimePicker.Name = "DateofBirthDateTimePicker"
        Me.DateofBirthDateTimePicker.Size = New System.Drawing.Size(200, 25)
        Me.DateofBirthDateTimePicker.TabIndex = 11
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Location = New System.Drawing.Point(429, 268)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(75, 18)
        OccupationLabel.TabIndex = 12
        OccupationLabel.Text = "Occupation:"
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Occupation", True))
        Me.OccupationTextBox.Location = New System.Drawing.Point(540, 265)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(200, 25)
        Me.OccupationTextBox.TabIndex = 13
        '
        'Physical_addressLabel
        '
        Physical_addressLabel.AutoSize = True
        Physical_addressLabel.Location = New System.Drawing.Point(429, 299)
        Physical_addressLabel.Name = "Physical_addressLabel"
        Physical_addressLabel.Size = New System.Drawing.Size(105, 18)
        Physical_addressLabel.TabIndex = 14
        Physical_addressLabel.Text = "Physical address:"
        '
        'Physical_addressTextBox
        '
        Me.Physical_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Physical address", True))
        Me.Physical_addressTextBox.Location = New System.Drawing.Point(540, 296)
        Me.Physical_addressTextBox.Name = "Physical_addressTextBox"
        Me.Physical_addressTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Physical_addressTextBox.TabIndex = 15
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(429, 330)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(54, 18)
        ContactLabel.TabIndex = 16
        ContactLabel.Text = "Contact:"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(540, 327)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(200, 25)
        Me.ContactTextBox.TabIndex = 17
        '
        'AffectionLabel
        '
        AffectionLabel.AutoSize = True
        AffectionLabel.Location = New System.Drawing.Point(429, 361)
        AffectionLabel.Name = "AffectionLabel"
        AffectionLabel.Size = New System.Drawing.Size(65, 18)
        AffectionLabel.TabIndex = 18
        AffectionLabel.Text = "Affection:"
        '
        'AffectionTextBox
        '
        Me.AffectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Affection", True))
        Me.AffectionTextBox.Location = New System.Drawing.Point(540, 358)
        Me.AffectionTextBox.Name = "AffectionTextBox"
        Me.AffectionTextBox.Size = New System.Drawing.Size(200, 25)
        Me.AffectionTextBox.TabIndex = 19
        '
        'DrugsLabel
        '
        DrugsLabel.AutoSize = True
        DrugsLabel.Location = New System.Drawing.Point(429, 392)
        DrugsLabel.Name = "DrugsLabel"
        DrugsLabel.Size = New System.Drawing.Size(47, 18)
        DrugsLabel.TabIndex = 20
        DrugsLabel.Text = "Drugs:"
        '
        'DrugsTextBox
        '
        Me.DrugsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Drugs", True))
        Me.DrugsTextBox.Location = New System.Drawing.Point(540, 389)
        Me.DrugsTextBox.Name = "DrugsTextBox"
        Me.DrugsTextBox.Size = New System.Drawing.Size(200, 25)
        Me.DrugsTextBox.TabIndex = 21
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.PharmacyDataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Location = New System.Drawing.Point(34, 262)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(89, 18)
        Employee_IDLabel.TabIndex = 0
        Employee_IDLabel.Text = "Employee ID:"
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Employee ID", True))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(129, 259)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(100, 25)
        Me.Employee_IDTextBox.TabIndex = 1
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(34, 293)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(45, 18)
        NameLabel1.TabIndex = 2
        NameLabel1.Text = "Name:"
        '
        'NameTextBox1
        '
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Name", True))
        Me.NameTextBox1.Location = New System.Drawing.Point(129, 290)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.NameTextBox1.TabIndex = 3
        '
        'SurnameLabel1
        '
        SurnameLabel1.AutoSize = True
        SurnameLabel1.Location = New System.Drawing.Point(34, 324)
        SurnameLabel1.Name = "SurnameLabel1"
        SurnameLabel1.Size = New System.Drawing.Size(61, 18)
        SurnameLabel1.TabIndex = 4
        SurnameLabel1.Text = "Surname:"
        '
        'SurnameTextBox1
        '
        Me.SurnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Surname", True))
        Me.SurnameTextBox1.Location = New System.Drawing.Point(129, 321)
        Me.SurnameTextBox1.Name = "SurnameTextBox1"
        Me.SurnameTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.SurnameTextBox1.TabIndex = 5
        '
        'GenderLabel1
        '
        GenderLabel1.AutoSize = True
        GenderLabel1.Location = New System.Drawing.Point(34, 355)
        GenderLabel1.Name = "GenderLabel1"
        GenderLabel1.Size = New System.Drawing.Size(54, 18)
        GenderLabel1.TabIndex = 6
        GenderLabel1.Text = "Gender:"
        '
        'GenderTextBox1
        '
        Me.GenderTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Gender", True))
        Me.GenderTextBox1.Location = New System.Drawing.Point(129, 352)
        Me.GenderTextBox1.Name = "GenderTextBox1"
        Me.GenderTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.GenderTextBox1.TabIndex = 7
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(329, 259)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(80, 18)
        DepartmentLabel.TabIndex = 8
        DepartmentLabel.Text = "Department:"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(424, 256)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(100, 25)
        Me.DepartmentTextBox.TabIndex = 9
        '
        'National_IDLabel
        '
        National_IDLabel.AutoSize = True
        National_IDLabel.Location = New System.Drawing.Point(329, 290)
        National_IDLabel.Name = "National_IDLabel"
        National_IDLabel.Size = New System.Drawing.Size(82, 18)
        National_IDLabel.TabIndex = 10
        National_IDLabel.Text = "National ID:"
        '
        'National_IDTextBox
        '
        Me.National_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "National ID", True))
        Me.National_IDTextBox.Location = New System.Drawing.Point(424, 287)
        Me.National_IDTextBox.Name = "National_IDTextBox"
        Me.National_IDTextBox.Size = New System.Drawing.Size(100, 25)
        Me.National_IDTextBox.TabIndex = 11
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(329, 321)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(59, 18)
        AddressLabel.TabIndex = 12
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(424, 318)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 25)
        Me.AddressTextBox.TabIndex = 13
        '
        'EmployeesDataGridView
        '
        Me.EmployeesDataGridView.AutoGenerateColumns = False
        Me.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.EmployeesDataGridView.DataSource = Me.EmployeesBindingSource
        Me.EmployeesDataGridView.Location = New System.Drawing.Point(3, 7)
        Me.EmployeesDataGridView.Name = "EmployeesDataGridView"
        Me.EmployeesDataGridView.Size = New System.Drawing.Size(743, 220)
        Me.EmployeesDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Employee ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "National ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "National ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DrugsBindingSource
        '
        Me.DrugsBindingSource.DataMember = "Drugs"
        Me.DrugsBindingSource.DataSource = Me.PharmacyDataSet
        '
        'DrugsTableAdapter
        '
        Me.DrugsTableAdapter.ClearBeforeFill = True
        '
        'Drug_IDLabel
        '
        Drug_IDLabel.AutoSize = True
        Drug_IDLabel.Location = New System.Drawing.Point(32, 260)
        Drug_IDLabel.Name = "Drug_IDLabel"
        Drug_IDLabel.Size = New System.Drawing.Size(63, 18)
        Drug_IDLabel.TabIndex = 0
        Drug_IDLabel.Text = "Drug ID:"
        '
        'Drug_IDTextBox
        '
        Me.Drug_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugsBindingSource, "Drug ID", True))
        Me.Drug_IDTextBox.Location = New System.Drawing.Point(144, 257)
        Me.Drug_IDTextBox.Name = "Drug_IDTextBox"
        Me.Drug_IDTextBox.Size = New System.Drawing.Size(166, 25)
        Me.Drug_IDTextBox.TabIndex = 1
        '
        'Drug_NameLabel
        '
        Drug_NameLabel.AutoSize = True
        Drug_NameLabel.Location = New System.Drawing.Point(32, 291)
        Drug_NameLabel.Name = "Drug_NameLabel"
        Drug_NameLabel.Size = New System.Drawing.Size(79, 18)
        Drug_NameLabel.TabIndex = 2
        Drug_NameLabel.Text = "Drug Name:"
        '
        'Drug_NameTextBox
        '
        Me.Drug_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugsBindingSource, "Drug Name", True))
        Me.Drug_NameTextBox.Location = New System.Drawing.Point(144, 288)
        Me.Drug_NameTextBox.Name = "Drug_NameTextBox"
        Me.Drug_NameTextBox.Size = New System.Drawing.Size(166, 25)
        Me.Drug_NameTextBox.TabIndex = 3
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(32, 322)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(61, 18)
        CategoryLabel.TabIndex = 4
        CategoryLabel.Text = "Category:"
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugsBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(144, 319)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(166, 25)
        Me.CategoryTextBox.TabIndex = 5
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(32, 353)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(40, 18)
        PriceLabel.TabIndex = 6
        PriceLabel.Text = "Price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugsBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(144, 350)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(166, 25)
        Me.PriceTextBox.TabIndex = 7
        '
        'SupplierLabel
        '
        SupplierLabel.AutoSize = True
        SupplierLabel.Location = New System.Drawing.Point(358, 260)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Size = New System.Drawing.Size(60, 18)
        SupplierLabel.TabIndex = 8
        SupplierLabel.Text = "Supplier:"
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugsBindingSource, "Supplier", True))
        Me.SupplierTextBox.Location = New System.Drawing.Point(470, 257)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.Size = New System.Drawing.Size(181, 25)
        Me.SupplierTextBox.TabIndex = 9
        '
        'Supplier_ContactLabel
        '
        Supplier_ContactLabel.AutoSize = True
        Supplier_ContactLabel.Location = New System.Drawing.Point(358, 291)
        Supplier_ContactLabel.Name = "Supplier_ContactLabel"
        Supplier_ContactLabel.Size = New System.Drawing.Size(106, 18)
        Supplier_ContactLabel.TabIndex = 10
        Supplier_ContactLabel.Text = "Supplier Contact:"
        '
        'Supplier_ContactTextBox
        '
        Me.Supplier_ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugsBindingSource, "Supplier Contact", True))
        Me.Supplier_ContactTextBox.Location = New System.Drawing.Point(470, 288)
        Me.Supplier_ContactTextBox.Name = "Supplier_ContactTextBox"
        Me.Supplier_ContactTextBox.Size = New System.Drawing.Size(181, 25)
        Me.Supplier_ContactTextBox.TabIndex = 11
        '
        'DrugsDataGridView
        '
        Me.DrugsDataGridView.AutoGenerateColumns = False
        Me.DrugsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrugsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.DrugsDataGridView.DataSource = Me.DrugsBindingSource
        Me.DrugsDataGridView.Location = New System.Drawing.Point(8, 17)
        Me.DrugsDataGridView.Name = "DrugsDataGridView"
        Me.DrugsDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.DrugsDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Drug ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Drug ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Drug Name"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Drug Name"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Supplier"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Supplier Contact"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Supplier Contact"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(424, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 36)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Add New"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(424, 388)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 38)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(424, 442)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(105, 38)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(546, 388)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(105, 38)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Next"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(285, 388)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(105, 38)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "Previous"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(444, 390)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(105, 38)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "Previous"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(705, 390)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(105, 38)
        Me.Button10.TabIndex = 21
        Me.Button10.Text = "Next"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(583, 444)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(105, 38)
        Me.Button11.TabIndex = 20
        Me.Button11.Text = "Delete"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(583, 390)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(95, 38)
        Me.Button12.TabIndex = 19
        Me.Button12.Text = "Save"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(583, 337)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(97, 36)
        Me.Button13.TabIndex = 18
        Me.Button13.Text = "Add New"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientsBindingNavigator.ResumeLayout(False)
        Me.PatientsBindingNavigator.PerformLayout()
        CType(Me.PatientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents PharmacyDataSet As Kaylie_Medical_Pharmacy_System.PharmacyDataSet
    Friend WithEvents PatientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientsTableAdapter As Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents TableAdapterManager As Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PatientsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Patient_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateofBirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OccupationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Physical_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AffectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DrugsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeesTableAdapter As Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents National_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DrugsTableAdapter As Kaylie_Medical_Pharmacy_System.PharmacyDataSetTableAdapters.DrugsTableAdapter
    Friend WithEvents DrugsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DrugsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Drug_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Drug_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Supplier_ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button

End Class
