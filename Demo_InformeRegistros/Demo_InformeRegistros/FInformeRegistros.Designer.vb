<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FInformeRegistros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DGVRegistrosTabla = New System.Windows.Forms.DataGridView()
        Me.MlacodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MladescriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MlaestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MlattynoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MlausuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MlausualtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MlafegrabaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MlafealtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AYMLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AY1_001DataSet = New Demo_InformeRegistros.AY1_001DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AY_MLATableAdapter = New Demo_InformeRegistros.AY1_001DataSetTableAdapters.AY_MLATableAdapter()
        CType(Me.DGVRegistrosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AYMLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AY1_001DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVRegistrosTabla
        '
        Me.DGVRegistrosTabla.AutoGenerateColumns = False
        Me.DGVRegistrosTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRegistrosTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MlacodigoDataGridViewTextBoxColumn, Me.MladescriDataGridViewTextBoxColumn, Me.MlaestadoDataGridViewTextBoxColumn, Me.MlattynoDataGridViewTextBoxColumn, Me.MlausuarioDataGridViewTextBoxColumn, Me.MlausualtaDataGridViewTextBoxColumn, Me.MlafegrabaDataGridViewTextBoxColumn, Me.MlafealtaDataGridViewTextBoxColumn})
        Me.DGVRegistrosTabla.DataSource = Me.AYMLABindingSource
        Me.DGVRegistrosTabla.Location = New System.Drawing.Point(18, 59)
        Me.DGVRegistrosTabla.Name = "DGVRegistrosTabla"
        Me.DGVRegistrosTabla.Size = New System.Drawing.Size(645, 326)
        Me.DGVRegistrosTabla.TabIndex = 0
        '
        'MlacodigoDataGridViewTextBoxColumn
        '
        Me.MlacodigoDataGridViewTextBoxColumn.DataPropertyName = "mla_codigo"
        Me.MlacodigoDataGridViewTextBoxColumn.HeaderText = "mla_codigo"
        Me.MlacodigoDataGridViewTextBoxColumn.Name = "MlacodigoDataGridViewTextBoxColumn"
        '
        'MladescriDataGridViewTextBoxColumn
        '
        Me.MladescriDataGridViewTextBoxColumn.DataPropertyName = "mla_descri"
        Me.MladescriDataGridViewTextBoxColumn.HeaderText = "mla_descri"
        Me.MladescriDataGridViewTextBoxColumn.Name = "MladescriDataGridViewTextBoxColumn"
        '
        'MlaestadoDataGridViewTextBoxColumn
        '
        Me.MlaestadoDataGridViewTextBoxColumn.DataPropertyName = "mla_estado"
        Me.MlaestadoDataGridViewTextBoxColumn.HeaderText = "mla_estado"
        Me.MlaestadoDataGridViewTextBoxColumn.Name = "MlaestadoDataGridViewTextBoxColumn"
        '
        'MlattynoDataGridViewTextBoxColumn
        '
        Me.MlattynoDataGridViewTextBoxColumn.DataPropertyName = "mla_ttyno"
        Me.MlattynoDataGridViewTextBoxColumn.HeaderText = "mla_ttyno"
        Me.MlattynoDataGridViewTextBoxColumn.Name = "MlattynoDataGridViewTextBoxColumn"
        '
        'MlausuarioDataGridViewTextBoxColumn
        '
        Me.MlausuarioDataGridViewTextBoxColumn.DataPropertyName = "mla_usuario"
        Me.MlausuarioDataGridViewTextBoxColumn.HeaderText = "mla_usuario"
        Me.MlausuarioDataGridViewTextBoxColumn.Name = "MlausuarioDataGridViewTextBoxColumn"
        '
        'MlausualtaDataGridViewTextBoxColumn
        '
        Me.MlausualtaDataGridViewTextBoxColumn.DataPropertyName = "mla_usu_alta"
        Me.MlausualtaDataGridViewTextBoxColumn.HeaderText = "mla_usu_alta"
        Me.MlausualtaDataGridViewTextBoxColumn.Name = "MlausualtaDataGridViewTextBoxColumn"
        '
        'MlafegrabaDataGridViewTextBoxColumn
        '
        Me.MlafegrabaDataGridViewTextBoxColumn.DataPropertyName = "mla_fegraba"
        Me.MlafegrabaDataGridViewTextBoxColumn.HeaderText = "mla_fegraba"
        Me.MlafegrabaDataGridViewTextBoxColumn.Name = "MlafegrabaDataGridViewTextBoxColumn"
        '
        'MlafealtaDataGridViewTextBoxColumn
        '
        Me.MlafealtaDataGridViewTextBoxColumn.DataPropertyName = "mla_fealta"
        Me.MlafealtaDataGridViewTextBoxColumn.HeaderText = "mla_fealta"
        Me.MlafealtaDataGridViewTextBoxColumn.Name = "MlafealtaDataGridViewTextBoxColumn"
        '
        'AYMLABindingSource
        '
        Me.AYMLABindingSource.DataMember = "AY_MLA"
        Me.AYMLABindingSource.DataSource = Me.AY1_001DataSet
        '
        'AY1_001DataSet
        '
        Me.AY1_001DataSet.DataSetName = "AY1_001DataSet"
        Me.AY1_001DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Informe de registros"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AY_MLATableAdapter
        '
        Me.AY_MLATableAdapter.ClearBeforeFill = True
        '
        'FInformeRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 398)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVRegistrosTabla)
        Me.Name = "FInformeRegistros"
        Me.Text = "Demo_InformeRegistros"
        CType(Me.DGVRegistrosTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AYMLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AY1_001DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVRegistrosTabla As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents AY1_001DataSet As AY1_001DataSet
    Friend WithEvents AYMLABindingSource As BindingSource
    Friend WithEvents AY_MLATableAdapter As AY1_001DataSetTableAdapters.AY_MLATableAdapter
    Friend WithEvents MlacodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MladescriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MlaestadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MlattynoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MlausuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MlausualtaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MlafegrabaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MlafealtaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
