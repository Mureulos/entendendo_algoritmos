def searchMinorMajor(arr, reverse = False):
    aux = arr[0]
    aux_index = 0

    for i in range(1, len(arr)):
        if reverse == False:
            if arr[i] < aux:
                aux = arr[i]
                aux_index = i
        else:
            if arr[i] > aux:
                aux = arr[i]
                aux_index = i
    
    return aux_index


def selectionSort(arr, reverse = False):
    newArray = []

    for i in range(len(arr)):
        if reverse == False:
            e = searchMinorMajor(arr)
        else:
            e = searchMinorMajor(arr, True)
        
        newArray.append(arr.pop(e))
    
    return newArray


print(selectionSort([5, 6, 2, 10, 3]))
print(selectionSort([5, 6, 2, 10, 3], True))