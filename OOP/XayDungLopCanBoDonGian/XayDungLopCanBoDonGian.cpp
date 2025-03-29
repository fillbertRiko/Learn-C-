//Bài 2: Xây dựng lớp cán bộ với các thông tin cơ bản.
#include <iostream>
#include <stdio.h>
using namespace std;

//khai bao class CanBo
class CanBo
{
private:
	string hoTen;
	int namSinh;
	int heSoLuong;
	string maCanBo;
public:
	CanBo(string hoTen, int namSinh, int heSoLuong, string maCanBo);
	void Show();
};

//Chuong trinh chinh
int main()
{
	cout << "Chuong trinh quan ly can bo\n";
	CanBo cb1("Nguyen Van A", 1990, 2, "CB001");
	CanBo cb2("Nguyen Van B", 1995, 3, "CB002");
	CanBo cb3("Nguyen Van C", 1998, 4, "CB003");
	cb1.Show();
	cb2.Show();
	cb3.Show();
	cout << endl;
	return 0;
}
//dinh nghia ham
CanBo::CanBo(string hoTen, int namSinh, int heSoLuong, string maCanBo)
{
	this->hoTen = hoTen;
	this->namSinh = namSinh;
	this->heSoLuong = heSoLuong;
	this->maCanBo = maCanBo;
}

void CanBo::Show()
{
	cout << "Ho ten: " << hoTen << endl;
	cout << "Nam sinh: " << namSinh << endl;
	cout << "He so luong: " << heSoLuong << endl;
	cout << "Ma can bo: " << maCanBo << endl;
}