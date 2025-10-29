voted = {}

def verify_voter(name):
    if voted.get(name):
        return "Go away!"
    else:
        voted[name] = True
        return "Vote"

print(verify_voter("tom"))
print(verify_voter("mike"))
print(verify_voter("mike"))