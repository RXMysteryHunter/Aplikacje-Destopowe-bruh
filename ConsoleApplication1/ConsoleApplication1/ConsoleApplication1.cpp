#include <iostream>
#include <unordered_map>

double calculateAverage(int array[], int size) {
    double average = 0.0;

    if (size == 0) {
        return average;
    }

    int sum = 0;

    for (int i = 0; i < size; i++) {
        sum = sum + array[i];
    }

    average = static_cast<double>(sum) / size;

    return average;
}

int countGreaterThanOrEqual(int array[], int size) {
    double averageValue = calculateAverage(array, size);
    int count = 0;

    for (int i = 0; i < size; i++) {
        if (array[i] > averageValue) {
            count++;
        }
    }

    return count;
}

void reverseArray(int array[], int size) {
    for (int i = 0; i < size / 2; i++) {
        int temp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = temp;
    }
}

void calculateFrequency(const int array[], int size) {
    if (size == 0) {
        return;
    }

    std::cout << "Frequency of occurrence:";
    std::unordered_map<int, int> frequency;
    for (int i = 0; i < size; i++) {
        frequency[array[i]]++;
    }

    for (const auto pair : frequency) {
        std::cout << " " << pair.first << ": " << pair.second;
    }
    std::cout << std::endl;
}

int* findLongestIncreasingSubsequence(const int array[], int size, int& subsequenceSize) {
    if (size == 0) {
        subsequenceSize = 0;
        return nullptr;
    }

    int* currentSubsequence = new int[size];
    int* longestSubsequence = new int[size];
    int currentLength = 1;
    int longestLength = 1;
    currentSubsequence[0] = array[0];

    for (int i = 1; i < size; i++) {
        if (array[i] > array[i - 1]) {
            currentSubsequence[currentLength] = array[i];
            currentLength++;
        }
        else {
            if (currentLength > longestLength) {
                longestLength = currentLength;
                delete[] longestSubsequence;
                longestSubsequence = new int[currentLength];
                for (int j = 0; j < currentLength; j++) {
                    longestSubsequence[j] = currentSubsequence[j];
                }
            }
            currentLength = 1;
            currentSubsequence[0] = array[i];
        }
    }

    if (currentLength > longestLength) {
        longestLength = currentLength;
        delete[] longestSubsequence;
        longestSubsequence = new int[currentLength];
        for (int j = 0; j < currentLength; j++) {
            longestSubsequence[j] = currentSubsequence[j];
        }
    }

    subsequenceSize = longestLength;
    delete[] currentSubsequence;
    return longestSubsequence;
}

void splitIntoEvenAndOdd(const int array[], int size, int*& evenArray, int& evenSize, int*& oddArray, int& oddSize) {
    evenSize = 0;
    oddSize = 0;

    for (int i = 0; i < size; i++) {
        if (array[i] % 2 == 0) {
            evenSize++;
        }
        else {
            oddSize++;
        }
    }

    evenArray = new int[evenSize];
    oddArray = new int[oddSize];

    int evenIndex = 0;
    int oddIndex = 0;

    for (int i = 0; i < size; i++) {
        if (array[i] % 2 == 0) {
            evenArray[evenIndex] = array[i];
            evenIndex++;
        }
        else {
            oddArray[oddIndex] = array[i];
            oddIndex++;
        }
    }
}

int main() {
    int data[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int size = sizeof(data) / sizeof(data[0]);

    double averageValue = calculateAverage(data, size);
    std::cout << "Average: " << averageValue << std::endl;

    int countGreater = countGreaterThanOrEqual(data, size);
    std::cout << "Count of numbers greater than or equal to the average: " << countGreater << std::endl;

    reverseArray(data, size);

    std::cout << "Reversed order: ";
    for (int i = 0; i < size; i++) {
        std::cout << data[i] << " ";
    }
    std::cout << std::endl;

    calculateFrequency(data, size);

    int subsequenceSize;
    int* subsequence = findLongestIncreasingSubsequence(data, size, subsequenceSize);
    std::cout << "Longest increasing subsequence:";
    for (int i = 0; i < subsequenceSize; i++) {
        std::cout << " " << subsequence[i];
    }
    std::cout << std::endl;
    delete[] subsequence;

    int* evenNumbers;
    int evenSize;
    int* oddNumbers;
    int oddSize;
    splitIntoEvenAndOdd(data, size, evenNumbers, evenSize, oddNumbers, oddSize);

    std::cout << "Even numbers:";
    for (int i = 0; i < evenSize; i++) {
        std::cout << " " << evenNumbers[i];
    }
    std::cout << std::endl;

    std::cout << "Odd numbers:";
    for (int i = 0; i < oddSize; i++) {
        std::cout << " " << oddNumbers[i];
    }
    std::cout << std::endl;

    delete[] evenNumbers;
    delete[] oddNumbers;

    return 0;
}
