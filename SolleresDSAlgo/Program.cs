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


    //Delete A Node
    SinglyLinkedListNode* deleteNode(SinglyLinkedListNode* llist, int position)
    {
        int currentPosition = 0;
        SinglyLinkedListNode* currentNode = llist;
        SinglyLinkedListNode* lastNode;


        if (llist == NULL)
        {
            return NULL;
        }
        if (llist->next == NULL && position == 0)
        {
            return NULL;
        }
        if (position == 0)
        {
            return llist->next;
        }
        while (currentPosition != position)
        {
            lastNode = currentNode;
            currentNode = currentNode->next;
            currentPosition++;
        }
        lastNode->next = currentNode->next;
        return llist;
    }


    //Print in Reverse
    void reversePrint(SinglyLinkedListNode* llist)
    {
        if (llist == NULL)
        {
            return;
        }
        reversePrint(llist->next);

        cout << llist->data << endl;

    }


    //Compare 2 linked list
    bool compare_lists(SinglyLinkedListNode* head1, SinglyLinkedListNode* head2)
    {
        SinglyLinkedListNode* cur1 = head1;
        SinglyLinkedListNode* cur2 = head2;

        while (cur1 && cur2)
        {
            if (cur1->data != cur2->data)
                return 0;
            else
            {
                cur1 = cur1->next;
                cur2 = cur2->next;
            }
        }
        if ((cur1 == NULL) && (cur2 == NULL))
            return 1;
        else
            return 0;

    }

