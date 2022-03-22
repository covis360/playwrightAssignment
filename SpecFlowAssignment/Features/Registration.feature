Feature: Parabank site

	
    Scenario: Register a user to site with valid data
        Given parabank site is loaded
        And navigate to register page
        And Fill and submit registration form
        	| Key            | Value           |
            | firstName      | Dimitris        |
            | lastName       | Vouvopoulos     |
            | address        | Iras 50         |
            | city           | Iraklio Attikis |
            | state          | Atiki           |
            | zipCode        | 14121           |
            | phoneNumber    | +306970909290   |
            | ssn            | 122416702       |
            | userName       | d.vouvop1       |
            | password       | 1234qwer        |
            | passwordRepeat | 1234qwer        |     
        Then Verify user is registered    
        