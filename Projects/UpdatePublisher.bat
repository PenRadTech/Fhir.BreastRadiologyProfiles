
if not exist "build\input-cache\" mkdir "build\input-cache"

pushd IG
call _updatePublisher.bat
popd

