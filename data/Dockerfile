FROM mongo
ENV database=UserDb
ENV collection=User
ENV host=mongo

COPY data.json .
CMD mongoimport --host $host --db $database --collection $collection  --type json --jsonArray --file ./data.json