## Running the app

# 1st step: build the image with docker
docker build -t desafio-pratico .

# 2nd step: run the image
docker run -d -p 8080:8080 -p 8081:8081 --name desafio-pratico desafio-pratico

# 3rd step: access the API
curl http://localhost:8080/api/pessoas
