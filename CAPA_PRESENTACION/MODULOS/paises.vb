Module paises
    Sub llenarComboBox(ByVal cbPaises As ComboBox)
        Dim objDic As New Dictionary(Of String, String)()

        For Each ObjCultureInfo As System.Globalization.CultureInfo In System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.SpecificCultures)
            Dim objRegionInfo As New System.Globalization.RegionInfo(ObjCultureInfo.Name)
            If Not objDic.ContainsKey(objRegionInfo.DisplayName) Then
                objDic.Add(objRegionInfo.DisplayName, objRegionInfo.TwoLetterISORegionName.ToLower())
            End If
        Next

        Dim obj = objDic.OrderBy(Function(p) p.Key)

        For Each val As KeyValuePair(Of String, String) In obj
            cbPaises.Items.Add(val.Key)
        Next

        cbPaises.SelectedIndex = 0

    End Sub
End Module
