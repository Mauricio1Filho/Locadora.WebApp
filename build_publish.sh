export IMAGENAME=registry.dubaismoke.net.br:5000/api-locadora:1.0.0
docker build --network=host -t $IMAGENAME -f ./src/Locadora.WebApp/Dockerfile .
docker rm -f api-locadora
docker run -d --name api-locadora -p 5001:80 -e ASPNETCORE_ENVIRONMENT=prod --restart=always $IMAGENAME
docker rmi -f $IMAGENAME
