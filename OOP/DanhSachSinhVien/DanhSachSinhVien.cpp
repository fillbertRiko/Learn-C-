//Bài 3: Nhập vào danh sách các sinh viên. Biết rằng mỗi sinh viên gồm các thông tin như mã sinh viên, học tên, quê quán, điểm trung bình. Sau đó sắp xếp danh sách sinh viên theo thứ tự tăng dần theo trường điểm trung bình.
#include <iostream>
#include <stdio.h>

using namespace std;
//khai bao class SinhVien
class SinhVien
{
private:
	int stt;
	char maSV[10];
	char hoTen[30];
	char queQuan[30];
	float diemTB;
public: 
	void nhap();
	void xuat();
	float layDiemTB();
};

class Node
{
private:
	SinhVien infor;
	Node* link;
public:
	Node(SinhVien infor, Node* link)
	{
		this->infor = infor;
		this->link = link;
	}
	friend class SinhVien;
	void QInsert(Node*& F, Node*& R, SinhVien x);
	SinhVien QDelete(Node*& F, Node*& R);
	bool isEmpty(Node* F);
};

//Chuong trinh chinh
int main()
{
	cout << endl;
	return 0;
}
//dinh nghia ham
void SinhVien::nhap()
{
	cout << "Nhap ma sinh vien: ";
	cin >> this->maSV;
	cout << "Nhap ho ten sinh vien: ";
	cin >> this->hoTen;
	cout << "Nhap que quan sinh vien: ";
	cin >> this->queQuan;
	cout << "Nhap diem trung binh: ";
	cin >> this->diemTB;
	++this->stt;
}

float SinhVien::layDiemTB()
{
	return this->diemTB;
}

void SinhVien::xuat()
{
	for (int i = 0; i < this->stt; i++)
	{
		
	}
}

void Node::QInsert(Node*& F, Node*& R, SinhVien x)
{
	Node* P = new Node(x, NULL);
	if (P == NULL)
	{
		cout << "Khong du bo nho de cap phat";
		return;
	}
	if (isEmpty(F))
	{
		F = R = P;
	}
	else
	{
		R->link = P;
		R = P;
	}
}
SinhVien Node::QDelete(Node*& F, Node*& R)  
{  
if (isEmpty(F))  
{  
	cout << "Hang doi rong";  
	return SinhVien(); // Return a default-constructed SinhVien object  
}  
Node* P = F;  
SinhVien x = P->infor;  
F = F->link;  
if (F == NULL)  
{  
	R = NULL;  
}  
delete P;  
return x;  
}
bool Node::isEmpty(Node* F)
{
	return F == NULL;
}