export IMAGENAME=registry.dubaismoke.net.br:5000/api-users:1.0.0
docker build --network=host -t $IMAGENAME -f ./src/DubaiSmoke.Users.Api/Dockerfile .
docker rm -f api-users
docker run -d --name api-users -p 5001:80 -e ASPNETCORE_ENVIRONMENT=prod --restart=always $IMAGENAME
docker rmi -f $IMAGENAME
