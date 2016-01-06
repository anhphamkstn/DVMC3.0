Namespace CommonMsgNumber
    Public Enum eDatabaseMsg
        Not_null_field = 1
        Have_unique_code = 2
        Have_reference = 3
        Not_have_parent_data = 4
        Not_connect_to_db_server = 7
        Not_update_because_have_ref = 15
    End Enum

    Public Enum eConfirmMsg
        Sure_to_delete = 8
        Sure_to_update = 11
        Continue_to_update = 16
    End Enum

    Public Enum eDatatypeMsg
        Not_valid_number = 12
        Not_valid_date = 14
    End Enum

    Public Enum eLabelMsg
        All = 18
    End Enum
End Namespace
