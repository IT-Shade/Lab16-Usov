int[] arrayB = { 5, -3, 8, -1, 0, -7, 4 };
for (int i = 0; i < arrayB.Length; i++) {
    if (arrayB[i] < 0) {
        arrayB[i] = 0;
    }
}

int[] arrayV = { 4, 7, 2, 9, 5 };
for (int i = 0; i < arrayV.Length - 1; i++) {
    for (int j = 0; j < arrayV.Length - 1 - i; j++) {
        if (arrayV[j] < arrayV[j + 1]) {
            int temp = arrayV[j];
            arrayV[j] = arrayV[j + 1];
            arrayV[j + 1] = temp;
        }
    }
}