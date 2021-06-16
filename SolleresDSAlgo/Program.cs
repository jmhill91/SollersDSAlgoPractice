using System;

namespace SolleresDSAlgo
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode* next;
     * };
     *
     */

    //print linked list
    void printLinkedList(SinglyLinkedListNode* head)
    {
        SinglyLinkedListNode* current = head;
        while (current != NULL)
        {
            cout << current->data << endl;
            current = current->next;
        }

    }

    // insert new node at tail
    SinglyLinkedListNode* insertNodeAtTail(SinglyLinkedListNode* head, int data)
    {
        SinglyLinkedListNode* current = head;
        SinglyLinkedListNode* newNode = new SinglyLinkedListNode(data);

        if (head == NULL)
        {
            head = newNode;
            return newNode;
        }
        while (current->next != NULL)
        {
            current = current->next;
        }
        current->next = newNode;
        cout << newNode->data << endl;
        return head;
    }

    //insert new node at head
    SinglyLinkedListNode* insertNodeAtHead(SinglyLinkedListNode* llist, int data)
    {
        SinglyLinkedListNode* newHead = new SinglyLinkedListNode(data);
        SinglyLinkedListNode* currentHead = llist;
        if (llist == NULL)
        {
            return newHead;
        }
        else
        {
            newHead->next = currentHead;
            cout << newHead->data << endl;
            return newHead;
        }
    }


    //insert node at specific position in linked list
}
