import csv

with open('nomes.csv','w', newline='') as csvfile:
    campos_head=['nomes,Idade']
    writer = csv.DictWriter(csvfile, fieldnames=campos_head)
    
    writer.writeheader()
    writer.writerow({'Nomes':'Alberto','idade':'30'})
