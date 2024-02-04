# deannesmeaton-blog-api

## Summary
This project is a simple blog, with api function to access the blog dataset.

## Getting started
To run the application you can do so by running:
```
docker compose up
```


> Note: you will need to set up the environment varibles for `MONGO_INITDB_ROOT_USERNAME` and
`MONGO_INITDB_ROOT_PASSWORD` in a `.env`

The function is run on:

http://localhost:7132

Sample function:

http://localhost:7132/api/HttpExample

Mongo Database can be accessed on:

mongodb://`<DB USER NAME>`:`<DB USERNAME PSWD>`@localhost:27017/