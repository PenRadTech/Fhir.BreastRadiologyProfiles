del /q Lib\*.dll
del /q Lib\*.pdb
del /q Lib\*.json
del /q Lib\*.zip
copy ..\..\Fhir\FhirKhit\Projects\PreFhir\PreFhir\bin\Debug\netcoreapp3.1\*.* .\Lib
pause
