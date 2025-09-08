def binary_search(lista, item):
    inicio = 0
    fim = len(lista) - 1

    while inicio <= fim:
        meio = (inicio + fim) // 2

        if lista[meio] == item:
            return meio

        if lista[meio] < item:
            inicio = meio + 1
        else:
            fim = meio - 1
    return None

# Teste
lista = [1, 3, 5, 7, 11, 13, 17, 19, 23]
print(binary_search(lista, 13))
print(binary_search(lista, 17))
print(binary_search(lista, 29))
