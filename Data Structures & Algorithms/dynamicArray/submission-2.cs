public class DynamicArray {
    private int[] arrList;
    private int capacity;
    private int length;

    public DynamicArray(int capacity) {
        this.capacity = capacity;
        this.length = 0;
        this.arrList = new int[capacity];
    }

    public int Get(int i) {
        return arrList[i];
    }

    public void Set(int i, int n) {
        arrList[i] = n;
    }

    public void PushBack(int n) {
        if (length == capacity)
        {
            Resize();
        }
        arrList[length] = n;
        length++;
    }

    public int PopBack() {
        if (length > 0) {
            // soft delete the last element
            length--;
        }
        return arrList[length];
    }

    private void Resize() {
        this.capacity *= 2;
        int[] newArr = new int[this.capacity];
        for (int i = 0; i < this.length; i++)
        {
            newArr[i] = arrList[i];
        }
        arrList = newArr;
    }

    public int GetSize() {
        return this.length;
    }

    public int GetCapacity() {
        return this.capacity;
    }
}
