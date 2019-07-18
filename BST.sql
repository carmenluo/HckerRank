/*
You are given a table, BST, containing two columns: N and P, where N represents the value of a node in Binary Tree, and P is the parent of N.
*/


 SELECT N, IF(P IS NULL, 'Root', IF(
     (SELECT COUNT(*) 
        FROM BST 
        WHERE P=B.N)
     >0, 'Inner', 'Leaf')) 
     FROM BST 
     AS B 
     ORDER BY N;

 select case 
    when P is null then concat (N, ' Root')
    when n in (select distinct P from bst) then concat (N, ' Inner')
    else concat(N, ' Leaf')
    end
from bst
order by N asc