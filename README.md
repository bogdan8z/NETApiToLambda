# Deploy .net api into AWS Lambda
How can we deploy a .NET api endpoint (GET /api/weatherforecast) into a lambda


### Steps:
1. Create simple .NET project
2. Add builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);
3. Install nodejs
4. Install serverless : >npm i serverless -g
5. add serverless.yml file


#### Steps to deploy:
1. 
  > cd apitolamda
 
  > dotnet lambda package --configuration Release       --function-architecture arm64       --output-package bin/release/publish/package.zip

2.
  > cd ..
  
  > serverless deploy
  
result: we have our endpoint GET https://<some_id>.execute-api.eu-west-1.amazonaws.com/dev/api/weatherforecast

Later we can include these 2 command in a pipeline
			

	  

##### Links
[Creating & deploying a .NET Core Web API to AWS with the Serverless Framework](https://www.karam.io/blog/2019/creating-and-deploying-a-net-core-web-api-to-aws-with-the-serverless-framework/)<br>
[Serverless Framework  - Deploying to AWS](https://www.serverless.com/framework/docs/providers/aws/guide/deploying)<br>
[Serverless Framework  - CLI - AWS - deploy](https://www.serverless.com/framework/docs/providers/aws/cli-reference/deploy)<br>
[Serverless Framework - An Introduction](https://www.serverless.com/framework/docs)<br>
[Serverless Framework - AWS Lambda Functions](https://www.serverless.com/framework/docs/providers/aws/guide/functions)<br>
[AWS - Deploy an Existing ASP.NET Core Web API to AWS Lambda](https://aws.amazon.com/blogs/developer/deploy-an-existing-asp-net-core-web-api-to-aws-lambda/)<br>