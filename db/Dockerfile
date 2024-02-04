FROM mongo:7.0.5 
COPY ./init/ /docker-entrypoint-initdb.d
RUN node /docker-entrypoint-initdb.d/mongo-init.js
