root=$(pwd)

cd ${root}/protobuf-3.15.6/cmake

brew install cmake
cmake -G "Xcode" -DCMAKE_BUILD_TYPE=Release

xcodebuild build -project protobuf.xcodeproj -scheme protoc -configuration Release

cp Release/protoc /usr/local/bin/protoc
cp Release/protoc ${root}/src/protoc

cd ${root}/csharp

./generate_protos.sh

brew tap isen-ng/dotnet-sdk-versions
brew install dotnet-sdk3-1-300

./buildall.sh
