# Tarefas

## Tarefa 1

Escreva uma consulta usando linguagem SQL para encontrar os colaboradores que têm o salário mais alto em cada um dos departamentos.

A tabela Pessoa possui a relação de todos os colaboradores de uma empresa. Cada pessoa tem um Id, um salário, e também uma coluna para o ID do departamento.

|Id      |Nome            |Salario      |DeptId  |
|--------|----------------|-------------|--------|
|1       |Joe             |70000        |1       |
|2       |Henry           |80000        |2       |
|3       |Sam             |60000        |2       |
|4       |Max             |90000        |1       |

A tabela Departamento contém a lista de departamentos da empresa.

|Id      |Nome            |
|--------|----------------|
|1       |TI              |
|2       |Vendas          |

Resultado esperado:

|Departamento   |Pessoa          |Salario   |
|---------------|----------------|----------|
|xxxx           |xxxx            |?         |
|yyyy           |yyyy            |?         |

```sql
  SELECT D.NOME AS DEPARTAMENTO, P.NOME AS PESSOA, MAX(P.SALARIO) AS SALARIO
    FROM PESSOA P
    JOIN DEPARTAMENTO D ON(D.ID = P.DEPTID)
GROUP BY D.NOME, P.NOME
```

## Tarefa 2

Dado um array inteiro sem duplicidade, construa um algoritmo de uma árvore a partir das seguintes regras:

- A raiz da árvore deve ser o maior valor do array;
- Os galhos da esquerda devem ser compostos somente por números à esquerda do valor raiz, na ordem decrescente;
- Os galhos da direita devem ser compostos somente por número à direita do valor raiz, na ordem decrescente.