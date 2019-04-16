#include<stdio.h>

//Args
int sig;
void (*func)(int);
void (*signal(int sig, void (*func(int))))(int);

typedef void(*signal_t)(int);

signal_t signal2(int sig, signal_t func);

// 関数の部分適用？
// int と intを受け取りvoidを返す関数へのポインタを受け取る関数にintを部分適用した戻り値がvoid
// int と intを受け取りvoidを返す関数へのポインタを引数にとり、intを受け取り、voidを返す関数へのポインターである
int main(){
  printf("%p\n",func); 
  printf("%p\n",signal); 
  printf("%lu\n", sizeof(char));
  printf("%lu\n", sizeof(char *));
}
