
// MFC_COM_TEST.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������


// CMFC_COM_TESTApp:
// �йش����ʵ�֣������ MFC_COM_TEST.cpp
//

class CMFC_COM_TESTApp : public CWinAppEx
{
public:
	CMFC_COM_TESTApp();

// ��д
	public:
	virtual BOOL InitInstance();

// ʵ��

	DECLARE_MESSAGE_MAP()
};

extern CMFC_COM_TESTApp theApp;