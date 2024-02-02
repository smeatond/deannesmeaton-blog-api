print('Start #################################################################');
db = db.getSiblingDB('blog-db');

db.createCollection('blog_entries');

print('END #################################################################');
