
### Iniciando containers Mongo, ElasticSearch e Graylog
```
docker-compose up -d
```

Acessar UI na seguinte uri:

<http://localhost:9099/>


Navergar até `System/Inputs` pelo menu e criar uma entrda GELF UDP:
![alt text](images/01.png?raw=true=250x250 "Title")
![alt text](images/02.png?raw=true=250x250 "Title")

Executar o app com o seguinte comando:
```
dotnet watch run
```
<https://localhost:5001/swagger/index.html>

Executar o método GET.  

Retornar na UI do Graylog, no menu Search e ver o log gerado:

![alt text](images/03.png?raw=true=250x250 "Title")



<br>

### Referencias
<https://docs.graylog.org/docs/docker>