BEGIN
	
	-- Rollback in case of error
	DECLARE EXIT HANDLER FOR sqlexception
		BEGIN
			ROLLBACK;
		END;

	-- Rollback in case of warning
	DECLARE EXIT HANDLER FOR sqlwarning
		BEGIN
			ROLLBACK;
		END;
	
    -- Drop table if exists
    DROP TABLE IF EXISTS __items;
    
    -- Create temporary table
    CREATE TEMPORARY TABLE __items
		(artikel_id INT(11), aantal INT(11)) ENGINE = HEAP;

	-- Insert values
	START TRANSACTION;
		INSERT INTO __items(artikel_id, aantal)
			SELECT
				items.artikel_id,
                SUM(items.aantal)
			FROM items
            WHERE items.tijdstip IS NULL
            GROUP BY items.artikel_id;
	COMMIT;

	-- Get results
	SELECT
		__items.artikel_id,
		__items.aantal - artikelen.voorraad AS tekort
	FROM __items
    INNER JOIN artikelen
		ON __items.artikel_id = artikelen.artikel_id
	HAVING tekort > 0;
END