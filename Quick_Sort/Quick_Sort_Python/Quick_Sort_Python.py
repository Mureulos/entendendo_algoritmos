def quicksort(array):
    if len(array) < 2:
        return array #Base: arrays com 0 ou 1 elementos já estão ordenados

    else:
        pivo = array[0] #Caso recursivo

        menores = [i for i in array[1:] if i <= pivo]
        maiores = [i for i in array[1:] if i > pivo]

        return quicksort(menores) + [pivo] + quicksort(maiores)
        #return quicksort(maiores) + [pivo] + quicksort(menores) Ordem decrescente

print(quicksort([10, 5, 2, 3]))