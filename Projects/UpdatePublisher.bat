
if not exist "build\input-cache\" mkdir "build\input-cache"

pushd build
call _updatePublisher.bat
popd
