print("Algoritem se je zagnal")
print("Napiši večjo število")
x = input("")
print("Napiši manjšo število")
y = input("")


while int(x) > int(y) & int(y) != 0:
    kvocient = int(x)/int(y)
    print(kvocient)

    ostanek = int(x) - int(kvocient) * int(y)
    print(ostanek)

    q = int(kvocient) * int(y) + int(ostanek)
    print(q)

    x = y
    print(x)
    y = ostanek
    print(y)



print(x)
print("Je največji skupni delitelj")


