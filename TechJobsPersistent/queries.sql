--Part 1

SELECT COLUMN_NAME, DATA_TYPE FROM
	INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'jobs';

--Part 2

SELECT NAME FROM employers 
WHERE LOCATION = "St. Louis City";


--Part 3

SELECT * FROM skills 
INNER JOIN jobSkills ON skills.Id = jobskills.skillId 
WHERE jobskills.jobId IS NOT NULL 
ORDER BY NAME ASC;
