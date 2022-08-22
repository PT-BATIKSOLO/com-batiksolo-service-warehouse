docker build -f Dockerfile.test.build -t com-BatikSolo-service-purchasing-webapi:test-build .
docker create --name com-BatikSolo-service-purchasing-webapi-test-build com-BatikSolo-service-purchasing-webapi:test-build
mkdir bin
docker cp com-BatikSolo-service-purchasing-webapi-test-build:/out/. ./bin/publish
docker build -f Dockerfile.test -t com-BatikSolo-service-purchasing-webapi:test .
