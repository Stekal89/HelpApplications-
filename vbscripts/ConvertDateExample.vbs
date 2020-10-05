Dim d, strDates
strDateAsInput = InputBox("Bitte Werk eingeben:", "Parameter1 (Werk)")

d=CDate(strDateAsInput)

'0 = vbGeneralDate - Default. Returns date: mm/dd/yy and time if specified: hh:mm:ss PM/AM.
'1 = vbLongDate - Returns date: weekday, monthname, year
'2 = vbShortDate - Returns date: mm/dd/yy
'3 = vbLongTime - Returns time: hh:mm:ss PM/AM
'4 = vbShortTime - Return time: hh:mm

'd=CDate("2010-02-16 13:45")
strDates = "Datum: " & FormatDateTime(d)
strDates = strDates & vbNewLine & "Datum1: " &  FormatDateTime(d,1)
strDates = strDates & vbNewLine & "Datum2: " &  FormatDateTime(d,2)
strDates = strDates & vbNewLine & "Datum3: " &  FormatDateTime(d,3)
strDates = strDates & vbNewLine &  FormatDateTime(d,4)

WScript.Echo strDates