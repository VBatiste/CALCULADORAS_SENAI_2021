#include <iostream>
using namespace std;

int main(){
    int op;
    float num1, num2;
    
    cout << "Qual o primeiro número?" << endl;
    cin >> num1;

    cout << "Qual operador você irá usar? 1- Somar // 2- Subtrair //3- Multiplicação //4- Divisão " << endl;
    cin >> op;

    switch(op){
        case 1: //Soma
            cout << "Qual o segundo número?" << endl;
            cin >> num2;

            cout << "O resultado da soma é: " << num1 + num2 << endl<< endl;
            loop();
        break;

	    case 2: //Subtração
            cout << "Qual o segundo número?" << endl;
            cin >> num2;

            cout << "O resultado da subtração é: " << num1 - num2 << endl;
            loop();
	    break;
	    
	    case 3: //Mult
	        cout << "Qual o segundo número?" << endl;
	        cin >> num2;

            cout << "O resultado da multiplicação é: " << num1 * num2 << endl;
            loop();
        break;
        
        case 4:
            cout << "Qual o segundo número?" << endl;
            cin >> num2;

            cout << "O resultado da divisão é: " << num1 / num2 << endl;
            loop();
        break;
        
        default:
            cout << "Operador não encontrado!" << endl;
            main();
        break;
    }
}