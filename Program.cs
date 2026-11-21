int[] grades = { 4, 5, 3, 5, 4, 2 };

for (int i = 0; i < grades.Length - 1; i++) {
    for (int j = 0; j < grades.Length - 1 - i; j++) {
        if (grades[j] < grades[j + 1]) {
            int temp = grades[j];
            grades[j] = grades[j + 1];
            grades[j + 1] = temp;
        }
    }
}

foreach (int grade in grades) {
    Console.WriteLine(grade);
}

int[] GenerateScheduleSlots(int lessonsCount) {
    int[] slots = new int[lessonsCount];

    for (int i = 0; i < lessonsCount; i++) {
        slots[i] = i + 1;
    }

    return slots;
}

int[] GenerateEvenSlots(int lessonsCount) {
    int[] slots = new int[lessonsCount];

    for (int i = 0; i < lessonsCount; i++) {
        slots[i] = (i + 1) * 2;
    }

    return slots;
}

int[] slots = GenerateScheduleSlots(6);

foreach (int slot in slots) {
    Console.WriteLine(slot);
}

int[] evenSlots = GenerateEvenSlots(6);

foreach (int slot in evenSlots) {
    Console.WriteLine(slot);
}