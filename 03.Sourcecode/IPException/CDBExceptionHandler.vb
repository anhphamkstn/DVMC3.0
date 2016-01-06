'De enum nay ra ngoai de C# co`n nhi`n thay

Public Enum DBErrorIndex
    DuplicateIndex = 0
    NoParentFound = 1
    ChildRecordFound = 2
    NullValueNotAllowed = 3
    CheckConstraintViolated = 4
    NoDBConnection = 5
    RecordChanged = 6
    RecordDeleted = 7
    LockTimeOut = 8
    BusinessProcessLock = 9
    OtherDBException = 10
End Enum

Public Class CDBExceptionHandler
    Private Const NumberOfException = 11
#Region "Data Structure"
    Public Enum DBErrorIndex
        DuplicateIndex = 0
        NoParentFound = 1
        ChildRecordFound = 2
        NullValueNotAllowed = 3
        CheckConstraintViolated = 4
        NoDBConnection = 5
        RecordChanged = 6
        RecordDeleted = 7
        LockTimeOut = 8
        BusinessProcessLock = 9
        OtherDBException = 10
    End Enum
#End Region

#Region "Các member của Class"

    Private m_Exception As System.Exception
    Private m_ErrorMsg() As String
    Private m_ErrorIndex As DBErrorIndex

#End Region

#Region "Public Interface"
    Public Sub New(ByVal i_ExceptionToHandle As System.Exception, _
                   ByVal i_ExceptionInterpret As IPException.IDBExceptionInterpret)
        m_Exception = i_ExceptionToHandle
        InitErrorMsg()
        m_ErrorIndex = i_ExceptionInterpret.getDBErrorIndex(m_Exception)
        If m_ErrorIndex = DBErrorIndex.OtherDBException Then
            setErrorMsg(DBErrorIndex.OtherDBException, "Lỗi sau đây xuất hiện " & m_Exception.Message)
        End If
    End Sub

    Public Sub setErrorMsg(ByVal i_DBErrorIndex As DBErrorIndex, _
                            ByVal i_CustomizedErrorMessage As String)
        ' Dùng để định các thông báo mong muốn trước khi gọi showErrorMessage
        '  
        '
        m_ErrorMsg(i_DBErrorIndex) = i_CustomizedErrorMessage
    End Sub

    Public Sub setErrorMsg(ByVal i_DBErrorIndex As IP.Core.IPException.DBErrorIndex, _
                            ByVal i_CustomizedErrorMessage As String)
        ' Dùng để định các thông báo mong muốn trước khi gọi showErrorMessage
        '  
        '
        m_ErrorMsg(i_DBErrorIndex) = i_CustomizedErrorMessage
    End Sub

    Public Function getDBErrorIndex() As DBErrorIndex
        ' nếu không muốn hiện  message báo lỗi thì dùng cái này
        ' để định dạng lỗi. Và tiếp tục theo cách mong muốn
        Return Me.m_ErrorIndex
    End Function

    Public Sub showErrorMessage()
        ' 
        ' Hiện thị các error message
        '
        MsgBox(m_ErrorMsg(m_ErrorIndex))

    End Sub

    Public Function getErrorMsg() As String
        Return m_ErrorMsg(m_ErrorIndex)
    End Function
#End Region

#Region "Các private methods"
    Private Sub InitErrorMsg()
        ReDim m_ErrorMsg(NumberOfException - 1)
        m_ErrorMsg(DBErrorIndex.DuplicateIndex) = "Dữ liệu đã tồn tại. Điền dữ liệu khác"
        m_ErrorMsg(DBErrorIndex.NoParentFound) = "Không có dữ liệu cơ sở. Tác vụ không thực hiện được"
        m_ErrorMsg(DBErrorIndex.CheckConstraintViolated) = "Dữ liệu không hợp lệ"
        m_ErrorMsg(DBErrorIndex.NullValueNotAllowed) = "Dữ liệu phải khác rỗng"
        m_ErrorMsg(DBErrorIndex.ChildRecordFound) = "Đã dùng ở nơi khác. Tác vụ không thực hiện được"
        m_ErrorMsg(DBErrorIndex.NoDBConnection) = "Không kết nối được với Cơ sở dữ liệu"
        m_ErrorMsg(DBErrorIndex.RecordChanged) = "Bản ghi này đã bị thay đổi"
        m_ErrorMsg(DBErrorIndex.RecordDeleted) = "Bản ghi này đã bị xóa"
        m_ErrorMsg(DBErrorIndex.LockTimeOut) = "Bản ghi này đang có người sửa đổi"
        m_ErrorMsg(DBErrorIndex.BusinessProcessLock) = "Người khác đang sử dụng chức năng này. Làm ơn thử lại sau."
    End Sub
#End Region
End Class

