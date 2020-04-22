@SET JAVA_TOOL_OPTIONS=-Dfile.encoding=UTF-8
@pushd build
JAVA -jar input-cache\org.hl7.fhir.publisher.jar -ig ig.ini
@popd
@PAUSE