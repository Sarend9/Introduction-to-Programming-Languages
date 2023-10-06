import random

import redis

# нужно запустить redis-cli.exe перед работой

with redis.Redis() as redis_server:
    redis_server.lpush("queue", random.randint(0, 10))  # пушим слева

