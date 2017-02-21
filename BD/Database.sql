USE master;  
GO  
CREATE DATABASE SIAD_KAA   
ON  
PRIMARY    
    (NAME = SIAD_KAA_DATA_UNO,  
    FILENAME = 'A:\Database\Data\Data_1.mdf',  
    SIZE = 100MB,  
    MAXSIZE = 200,  
    FILEGROWTH = 20),  
    ( NAME = SIAD_KAA_DATA_DOS,  
    FILENAME = 'A:\Database\Data\Data_2.ndf',  
    SIZE = 100MB,  
    MAXSIZE = 200,  
    FILEGROWTH = 20),  
    ( NAME = SIAD_KAA_DATA_TRES,  
    FILENAME = 'A:\Database\Data\Data_3.ndf',  
    SIZE = 100MB,  
    MAXSIZE = 200,  
    FILEGROWTH = 20)  
LOG ON   
   (NAME = SIAD_KAA_LOG_UNO,  
    FILENAME = 'A:\Database\Logs\Log_1.ldf',  
    SIZE = 100MB,  
    MAXSIZE = 200,  
    FILEGROWTH = 20),  
   (NAME = SIAD_KAA_LOG_DOS,  
    FILENAME = 'A:\Database\Logs\Log_2.ldf',  
    SIZE = 100MB,  
    MAXSIZE = 200,  
    FILEGROWTH = 20) ;  
GO  