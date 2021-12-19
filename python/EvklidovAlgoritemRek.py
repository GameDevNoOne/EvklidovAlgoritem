def evklidov_algoritem(x, y):
    "Izračuna največji skupni delitelj dveh števil."
    if (x==y) | (y == 0):
        return x
    ostanek = x - x/y * y
    return evklidov_algoritem(y, ostanek)

print("Algoritem se je zagnal")
print("Napiši večjo število")
x = input("")
print("Napiši manjšo število")
y = input("")

nsd = evklidov_algoritem(int(x), int(y))

print("Največji skupni delitelj števil {} in {} je {}".format(x, y, nsd))