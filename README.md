<p align="center">
    <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" align="center" width="30%">
</p>
<p align="center"><h1 align="center">ECOMMERCEAPI</h1></p>
<p align="center">
	<em><code>❯ REPLACE-ME</code></em>
</p>
<p align="center">
	<img src="https://img.shields.io/github/license/Emir-Khan/ECommerceAPI?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/Emir-Khan/ECommerceAPI?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/Emir-Khan/ECommerceAPI?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/Emir-Khan/ECommerceAPI?style=default&color=0080ff" alt="repo-language-count">
</p>
<p align="center"><!-- default option, no dependency badges. -->
</p>
<p align="center">
	<!-- default option, no dependency badges. -->
</p>
<br>

##  Table of Contents

- [ Overview](#-overview)
- [ Features](#-features)
- [ Project Structure](#-project-structure)
  - [ Project Index](#-project-index)
- [ Getting Started](#-getting-started)
  - [ Prerequisites](#-prerequisites)
  - [ Installation](#-installation)
  - [ Usage](#-usage)
  - [ Testing](#-testing)
- [ Project Roadmap](#-project-roadmap)
- [ Contributing](#-contributing)
- [ License](#-license)
- [ Acknowledgments](#-acknowledgments)

---

##  Overview

ECommerceAPI is a robust and scalable API designed to handle various authentication mechanisms for an e-commerce platform. This project leverages the power of .NET 9 and C# 13.0 to provide secure and efficient user authentication and authorization services. The API supports multiple login methods, including traditional username/password, Google, and Facebook logins, as well as token-based authentication for session management.


---

##  Features

### Authentication
- **User Login**: Authenticate users using their username or email and password.
- **Google Login**: Allow users to log in using their Google account credentials.
- **Facebook Login**: Allow users to log in using their Facebook account credentials.
- **Refresh Token**: Support for refreshing authentication tokens to maintain user sessions without requiring re-login.
- **Password Reset**: Enable users to reset their passwords via email.
- **Verify Reset Token**: Verify the validity of password reset tokens.

### Order Management
- **Create Order**: Place a new order for products.
- **Order Details**: Retrieve details of a specific order.
- **Order History**: Get a list of past orders for a user.
- **Update Order Status**: Update the status of an existing order (e.g., processing, shipped, delivered).
- **Cancel Order**: Cancel an existing order.

### Cart Management
- **Add to Cart**: Add products to the user's shopping cart.
- **Remove from Cart**: Remove products from the user's shopping cart.
- **View Cart**: Retrieve the current contents of the user's shopping cart.
- **Update Cart**: Update quantities or details of items in the cart.



---

##  Project Structure

```sh
└── ECommerceAPI/
    ├── Core
    │   ├── ECommerceAPI.Application
    │   └── ECommerceAPI.Domain
    ├── Infrastructure
    │   ├── ECommerceAPI.Infrastructure
    │   ├── ECommerceAPI.Persistence
    │   └── ECommerceAPI.SignalR
    └── Presentation
        └── ECommerceAPI.API
```


###  Project Index
<details open>
	<summary><b><code>ECOMMERCEAPI/</code></b></summary>
	<details> <!-- __root__ Submodule -->
		<summary><b>__root__</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/ECommerceAPI.sln'>ECommerceAPI.sln</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Core Submodule -->
		<summary><b>Core</b></summary>
		<blockquote>
			<details>
				<summary><b>ECommerceAPI.Domain</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/ECommerceAPI.Domain.csproj'>ECommerceAPI.Domain.csproj</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
					<details>
						<summary><b>Entities</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Product.cs'>Product.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/CompletedOrder.cs'>CompletedOrder.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/BasketItem.cs'>BasketItem.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Order.cs'>Order.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/File.cs'>File.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/ProductImageFile.cs'>ProductImageFile.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/InvoiceFile.cs'>InvoiceFile.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Endpoint.cs'>Endpoint.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Menu.cs'>Menu.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Basket.cs'>Basket.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Customer.cs'>Customer.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
							<details>
								<summary><b>Common</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Common/BaseEntity.cs'>BaseEntity.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Identity</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Identity/AppRole.cs'>AppRole.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Domain/Entities/Identity/AppUser.cs'>AppUser.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
				</blockquote>
			</details>
			<details>
				<summary><b>ECommerceAPI.Application</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/ServiceRegistration.cs'>ServiceRegistration.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/ECommerceAPI.Application.csproj'>ECommerceAPI.Application.csproj</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
					<details>
						<summary><b>Exceptions</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Exceptions/UserCreateFailedException.cs'>UserCreateFailedException.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Exceptions/UserNotFoundException.cs'>UserNotFoundException.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Exceptions/PasswordChangeFieldException.cs'>PasswordChangeFieldException.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>RequestParameters</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/RequestParameters/Pagination.cs'>Pagination.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Enums</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Enums/ActionType.cs'>ActionType.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Consts</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Consts/AuthorizeDefinitionConstants.cs'>AuthorizeDefinitionConstants.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Features</b></summary>
						<blockquote>
							<details>
								<summary><b>Queries</b></summary>
								<blockquote>
									<details>
										<summary><b>AuthorizationEndpoint</b></summary>
										<blockquote>
											<details>
												<summary><b>GetEndpointRoles</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AuthorizationEndpoint/GetEndpointRoles/GetEndpointRolesQueryRequest.cs'>GetEndpointRolesQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AuthorizationEndpoint/GetEndpointRoles/GetEndpointRolesQueryResponse.cs'>GetEndpointRolesQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AuthorizationEndpoint/GetEndpointRoles/GetEndpointRolesQueryHandler.cs'>GetEndpointRolesQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>AppUser</b></summary>
										<blockquote>
											<details>
												<summary><b>GetMe</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AppUser/GetMe/GetMeQueryHandler.cs'>GetMeQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetUserRoles</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AppUser/GetUserRoles/GetUserRolesQueryHandler.cs'>GetUserRolesQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AppUser/GetUserRoles/GetUserRolesQueryResponse.cs'>GetUserRolesQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AppUser/GetUserRoles/GetUserRolesQueryRequest.cs'>GetUserRolesQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetAllUsers</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AppUser/GetAllUsers/GetAllUsersQueryResponse.cs'>GetAllUsersQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AppUser/GetAllUsers/GetAllUsersQueryRequest.cs'>GetAllUsersQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/AppUser/GetAllUsers/GetAllUsersQueryHandler.cs'>GetAllUsersQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>ProductImageFile</b></summary>
										<blockquote>
											<details>
												<summary><b>GetProductShowCaseImage</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/ProductImageFile/GetProductShowCaseImage/GetProductShowCaseImageQueryHandler.cs'>GetProductShowCaseImageQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/ProductImageFile/GetProductShowCaseImage/GetProductShowCaseImageQueryResponse.cs'>GetProductShowCaseImageQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/ProductImageFile/GetProductShowCaseImage/GetProductShowCaseImageQueryRequest.cs'>GetProductShowCaseImageQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetProductImages</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/ProductImageFile/GetProductImages/GetProductImagesQueryHandler.cs'>GetProductImagesQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/ProductImageFile/GetProductImages/GetProductImagesQueryRequest.cs'>GetProductImagesQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/ProductImageFile/GetProductImages/GetProductImagesQueryResponse.cs'>GetProductImagesQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>Role</b></summary>
										<blockquote>
											<details>
												<summary><b>GetRoles</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Role/GetRoles/GetRolesQueryResponse.cs'>GetRolesQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Role/GetRoles/GetRolesQueryRequest.cs'>GetRolesQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Role/GetRoles/GetRolesQueryHandler.cs'>GetRolesQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetRoleById</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Role/GetRoleById/GetRoleByIdQueryRequest.cs'>GetRoleByIdQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Role/GetRoleById/GetRoleByIdQueryResponse.cs'>GetRoleByIdQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Role/GetRoleById/GetRoleByIdQueryHandler.cs'>GetRoleByIdQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>Product</b></summary>
										<blockquote>
											<details>
												<summary><b>GetAllProduct</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Product/GetAllProduct/GetAllProductQueryHandler.cs'>GetAllProductQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Product/GetAllProduct/GetAllProductQueryResponse.cs'>GetAllProductQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Product/GetAllProduct/GetAllProductQueryRequest.cs'>GetAllProductQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetByIdProduct</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Product/GetByIdProduct/GetByIdProductQueryResponse.cs'>GetByIdProductQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Product/GetByIdProduct/GetByIdProductQueryHandler.cs'>GetByIdProductQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Product/GetByIdProduct/GetByIdProductQueryRequest.cs'>GetByIdProductQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>Order</b></summary>
										<blockquote>
											<details>
												<summary><b>GetOrderById</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Order/GetOrderById/GetOrderByIdQueryResponse.cs'>GetOrderByIdQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Order/GetOrderById/GetOrderByIdQueryRequest.cs'>GetOrderByIdQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Order/GetOrderById/GetOrderByIdQueryHandler.cs'>GetOrderByIdQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GetAllOrders</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Order/GetAllOrders/GetAllOrderQueryResponse.cs'>GetAllOrderQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Order/GetAllOrders/GetAllOrderQueryHandler.cs'>GetAllOrderQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Order/GetAllOrders/GetAllOrderQueryRequest.cs'>GetAllOrderQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>Basket</b></summary>
										<blockquote>
											<details>
												<summary><b>GetBasketItems</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Basket/GetBasketItems/GetBasketItemsQueryRequest.cs'>GetBasketItemsQueryRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Basket/GetBasketItems/GetBasketItemsQueryResponse.cs'>GetBasketItemsQueryResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Queries/Basket/GetBasketItems/GetBasketItemsQueryHandler.cs'>GetBasketItemsQueryHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
								</blockquote>
							</details>
							<details>
								<summary><b>Commands</b></summary>
								<blockquote>
									<details>
										<summary><b>AuthorizationEndpoint</b></summary>
										<blockquote>
											<details>
												<summary><b>AssignRoleEndpoint</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AuthorizationEndpoint/AssignRoleEndpoint/AssignRoleEndpointCommandRequest.cs'>AssignRoleEndpointCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AuthorizationEndpoint/AssignRoleEndpoint/AssignRoleEndpointCommandHandler.cs'>AssignRoleEndpointCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AuthorizationEndpoint/AssignRoleEndpoint/AssignRoleEndpointCommandResponse.cs'>AssignRoleEndpointCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>AppUser</b></summary>
										<blockquote>
											<details>
												<summary><b>PasswordReset</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/PasswordReset/PasswordResetCommandHandler.cs'>PasswordResetCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/PasswordReset/PasswordResetCommandRequest.cs'>PasswordResetCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/PasswordReset/PasswordResetCommandResponse.cs'>PasswordResetCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>GoogleLogin</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/GoogleLogin/GoogleLoginCommandRequest.cs'>GoogleLoginCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/GoogleLogin/GoogleLoginCommandHandler.cs'>GoogleLoginCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/GoogleLogin/GoogleLoginCommandResponse.cs'>GoogleLoginCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>RefreshTokenLogin</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/RefreshTokenLogin/RefreshTokenLoginRequest.cs'>RefreshTokenLoginRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/RefreshTokenLogin/RefreshTokenLoginResponse.cs'>RefreshTokenLoginResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/RefreshTokenLogin/RefreshTokenLoginHandler.cs'>RefreshTokenLoginHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>AssignRoleToUser</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/AssignRoleToUser/AssignRoleToUserCommandHandler.cs'>AssignRoleToUserCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/AssignRoleToUser/AssignRoleToUserCommandRequest.cs'>AssignRoleToUserCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/AssignRoleToUser/AssignRoleToUserCommandResponse.cs'>AssignRoleToUserCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>CreateUser</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/CreateUser/CreateUserCommandResponse.cs'>CreateUserCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/CreateUser/CreateUserCommandHandler.cs'>CreateUserCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/CreateUser/CreateUserCommandRequest.cs'>CreateUserCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>LoginUser</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/LoginUser/LoginUserCommandRequest.cs'>LoginUserCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/LoginUser/LoginUserCommandResponse.cs'>LoginUserCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/LoginUser/LoginUserCommandHandler.cs'>LoginUserCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>VerifyResetToken</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/VerifyResetToken/VerifyResetTokenCommandRequest.cs'>VerifyResetTokenCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/VerifyResetToken/VerifyResetTokenCommandHandler.cs'>VerifyResetTokenCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/VerifyResetToken/VerifyResetTokenCommandResponse.cs'>VerifyResetTokenCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>FacebookLogin</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/FacebookLogin/FacebookLoginCommandHandler.cs'>FacebookLoginCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/FacebookLogin/FacebookLoginCommandResponse.cs'>FacebookLoginCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/FacebookLogin/FacebookLoginCommandRequest.cs'>FacebookLoginCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>UpdatePassword</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/UpdatePassword/UpdatePasswordCommandHandler.cs'>UpdatePasswordCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/UpdatePassword/UpdatePasswordCommandRequest.cs'>UpdatePasswordCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/AppUser/UpdatePassword/UpdatePasswordCommandResponse.cs'>UpdatePasswordCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>ProductImageFile</b></summary>
										<blockquote>
											<details>
												<summary><b>UploadProductImage</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/ProductImageFile/UploadProductImage/UploadProductImageCommandResponse.cs'>UploadProductImageCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/ProductImageFile/UploadProductImage/UploadProductImageCommandHandler.cs'>UploadProductImageCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/ProductImageFile/UploadProductImage/UploadProductImageCommandRequest.cs'>UploadProductImageCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>RemoveProductImage</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/ProductImageFile/RemoveProductImage/RemoveProductImageCommandRequest.cs'>RemoveProductImageCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/ProductImageFile/RemoveProductImage/RemoveProductImageCommandResponse.cs'>RemoveProductImageCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/ProductImageFile/RemoveProductImage/RemoveProductImageCommandHandler.cs'>RemoveProductImageCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>Role</b></summary>
										<blockquote>
											<details>
												<summary><b>DeleteRole</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/DeleteRole/DeleteRoleCommandRequest.cs'>DeleteRoleCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/DeleteRole/DeleteRoleCommandResponse.cs'>DeleteRoleCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/DeleteRole/DeleteRoleCommandHandler.cs'>DeleteRoleCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/DeleteRole/IRoleRepository.cs'>IRoleRepository.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>UpdateRole</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/UpdateRole/UpdateRoleCommandRequest.cs'>UpdateRoleCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/UpdateRole/UpdateRoleCommandHandler.cs'>UpdateRoleCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/UpdateRole/UpdateRoleCommandResponse.cs'>UpdateRoleCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>CreateRole</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/CreateRole/CreateRoleCommandHandler.cs'>CreateRoleCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/CreateRole/CreateRoleCommandResponse.cs'>CreateRoleCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Role/CreateRole/CreateRoleCommandRequest.cs'>CreateRoleCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>Product</b></summary>
										<blockquote>
											<details>
												<summary><b>UpdateQrCodeProductStock</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/UpdateQrCodeProductStock/UpdateQrCodeProductStockCommandHandler.cs'>UpdateQrCodeProductStockCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/UpdateQrCodeProductStock/UpdateQrCodeProductStockCommandResponse.cs'>UpdateQrCodeProductStockCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/UpdateQrCodeProductStock/UpdateQrCodeProductStockCommandRequest.cs'>UpdateQrCodeProductStockCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>ChangeShowcase</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/ChangeShowcase/ChangeShowcaseCommandHandler.cs'>ChangeShowcaseCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/ChangeShowcase/ChangeShowcaseCommandRequest.cs'>ChangeShowcaseCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/ChangeShowcase/ChangeShowcaseCommandResponse.cs'>ChangeShowcaseCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>UpdateProduct</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/UpdateProduct/UpdateProductCommandHandler.cs'>UpdateProductCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/UpdateProduct/UpdateProductCommandRequest.cs'>UpdateProductCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/UpdateProduct/UpdateProductCommandResponse.cs'>UpdateProductCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>CreateProduct</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/CreateProduct/CreateProductCommandResponse.cs'>CreateProductCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/CreateProduct/CreateProductCommandHandler.cs'>CreateProductCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/CreateProduct/CreateProductCommandRequest.cs'>CreateProductCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>RemoveProduct</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/RemoveProduct/RemoveProductCommandResponse.cs'>RemoveProductCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/RemoveProduct/RemoveProductCommandRequest.cs'>RemoveProductCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Product/RemoveProduct/RemoveProductCommandHandler.cs'>RemoveProductCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>Order</b></summary>
										<blockquote>
											<details>
												<summary><b>CreateOrder</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Order/CreateOrder/CreateOrderCommandResponse.cs'>CreateOrderCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Order/CreateOrder/CreateOrderCommandRequest.cs'>CreateOrderCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Order/CreateOrder/CreateOrderCommandHandler.cs'>CreateOrderCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>CompleteOrder</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Order/CompleteOrder/CompleteOrderCommandHandler.cs'>CompleteOrderCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Order/CompleteOrder/CompleteOrderCommandResponse.cs'>CompleteOrderCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Order/CompleteOrder/CompleteOrderCommandRequest.cs'>CompleteOrderCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
									<details>
										<summary><b>Basket</b></summary>
										<blockquote>
											<details>
												<summary><b>RemoveBasketItem</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/RemoveBasketItem/RemoveBasketItemCommandResponse.cs'>RemoveBasketItemCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/RemoveBasketItem/RemoveBasketItemCommandHandler.cs'>RemoveBasketItemCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/RemoveBasketItem/RemoveBasketItemCommandRequest.cs'>RemoveBasketItemCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>AddItemToBasket</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/AddItemToBasket/AddItemToBasketCommandHandler.cs'>AddItemToBasketCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/AddItemToBasket/AddItemToBasketCommandResponse.cs'>AddItemToBasketCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/AddItemToBasket/AddItemToBasketCommandRequest.cs'>AddItemToBasketCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
											<details>
												<summary><b>UpdateQuantity</b></summary>
												<blockquote>
													<table>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/UpdateQuantity/UpdateQuantityCommandHandler.cs'>UpdateQuantityCommandHandler.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/UpdateQuantity/UpdateQuantityCommandResponse.cs'>UpdateQuantityCommandResponse.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													<tr>
														<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Features/Commands/Basket/UpdateQuantity/UpdateQuantityCommandRequest.cs'>UpdateQuantityCommandRequest.cs</a></b></td>
														<td><code>❯ REPLACE-ME</code></td>
													</tr>
													</table>
												</blockquote>
											</details>
										</blockquote>
									</details>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Abstractions</b></summary>
						<blockquote>
							<details>
								<summary><b>Hubs</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Hubs/IOrderHubService.cs'>IOrderHubService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Hubs/IProductHubService.cs'>IProductHubService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Services</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IProductService.cs'>IProductService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IRoleService.cs'>IRoleService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IQRCodeService.cs'>IQRCodeService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IAuthService.cs'>IAuthService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IAuthorizationEndpointService.cs'>IAuthorizationEndpointService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IUserService.cs'>IUserService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IOrderService.cs'>IOrderService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IMailService.cs'>IMailService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/IBasketService.cs'>IBasketService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
									<details>
										<summary><b>Configurations</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/Configurations/IApplicationService.cs'>IApplicationService.cs</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Authentication</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/Authentication/IExternalAuthentication.cs'>IExternalAuthentication.cs</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Services/Authentication/IInternalAuthentication.cs'>IInternalAuthentication.cs</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											</table>
										</blockquote>
									</details>
								</blockquote>
							</details>
							<details>
								<summary><b>Token</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Token/ITokenHandler.cs'>ITokenHandler.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Storage</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Storage/IStorageService.cs'>IStorageService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Storage/IStorage.cs'>IStorage.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
									<details>
										<summary><b>Azure</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Storage/Azure/IAzureStorage.cs'>IAzureStorage.cs</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Local</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Abstractions/Storage/Local/ILocalStorage.cs'>ILocalStorage.cs</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											</table>
										</blockquote>
									</details>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>DTOs</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Token.cs'>Token.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
							<details>
								<summary><b>Configuration</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Configuration/Action.cs'>Action.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Configuration/Menu.cs'>Menu.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Order</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Order/CompletedOrder.cs'>CompletedOrder.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Order/ListOrder.cs'>ListOrder.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Order/SingleOrder.cs'>SingleOrder.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Order/CreateOrder.cs'>CreateOrder.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>User</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/User/CreateUserResponse.cs'>CreateUserResponse.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/User/ListUser.cs'>ListUser.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/User/VerifyUserResetToken.cs'>VerifyUserResetToken.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/User/UserDetail.cs'>UserDetail.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/User/CreateUser.cs'>CreateUser.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Facebook</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Facebook/FacebookAccessTokenResponse.cs'>FacebookAccessTokenResponse.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Facebook/FacebookAccessTokenValidation.cs'>FacebookAccessTokenValidation.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/DTOs/Facebook/FacebookUserInfoResponse.cs'>FacebookUserInfoResponse.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Repositories</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/IReadRepository.cs'>IReadRepository.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/IWriteRepository.cs'>IWriteRepository.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/IRepository.cs'>IRepository.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
							<details>
								<summary><b>BasketItem</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/BasketItem/IBasketItemWriteRepository.cs'>IBasketItemWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/BasketItem/IBasketItemReadRepository.cs'>IBasketItemReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Customer</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Customer/ICustomerWriteRepository.cs'>ICustomerWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Customer/ICustomerReadRepository.cs'>ICustomerReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>ProductImageFile</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/ProductImageFile/IProductImageFileReadRepository.cs'>IProductImageFileReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/ProductImageFile/IProductImageFileWriteRepository.cs'>IProductImageFileWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>CompletedOrder</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/CompletedOrder/ICompletedOrderReadRepository.cs'>ICompletedOrderReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/CompletedOrder/ICompletedOrderWrtieRepository.cs'>ICompletedOrderWrtieRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Product</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Product/IProductReadRepository.cs'>IProductReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Product/IProductWriteRepository.cs'>IProductWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Endpoint</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Endpoint/IEndpointReadRepository.cs'>IEndpointReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Endpoint/IEndpointWriteRepository.cs'>IEndpointWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Order</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Order/IOrderReadRepository.cs'>IOrderReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Order/IOrderWriteRepository.cs'>IOrderWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Menu</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Menu/IMenuReadRepository.cs'>IMenuReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Menu/IMenuWriteRepository.cs'>IMenuWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Basket</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Basket/IBasketWriteRepository.cs'>IBasketWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/Basket/IBasketReadRepository.cs'>IBasketReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>File</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/File/IFileReadRepository.cs'>IFileReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/File/IFileWriteRepository.cs'>IFileWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>InvoiceFile</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/InvoiceFile/IInvoiceFileReadRepository.cs'>IInvoiceFileReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Repositories/InvoiceFile/IInvoiceFileWriteRepository.cs'>IInvoiceFileWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>CustomAttributes</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/CustomAttributes/AuthorizeDefinitionAttribute.cs'>AuthorizeDefinitionAttribute.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Helpers</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Helpers/CustomEncoders.cs'>CustomEncoders.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Validators</b></summary>
						<blockquote>
							<details>
								<summary><b>Products</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Validators/Products/CreateProductValidator.cs'>CreateProductValidator.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>AppUsers</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/Validators/AppUsers/UpdatePassword.cs'>UpdatePassword.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>ViewModels</b></summary>
						<blockquote>
							<details>
								<summary><b>Products</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/ViewModels/Products/VM_Create_Product.cs'>VM_Create_Product.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/ViewModels/Products/VM_Update_Product.cs'>VM_Update_Product.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Baskets</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/ViewModels/Baskets/VM_Create_BasketItem.cs'>VM_Create_BasketItem.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Core/ECommerceAPI.Application/ViewModels/Baskets/VM_Update_BasketItem.cs'>VM_Update_BasketItem.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
				</blockquote>
			</details>
		</blockquote>
	</details>
	<details> <!-- Presentation Submodule -->
		<summary><b>Presentation</b></summary>
		<blockquote>
			<details>
				<summary><b>ECommerceAPI.API</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/ECommerceAPI.API.csproj'>ECommerceAPI.API.csproj</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/appsettings.Development.json'>appsettings.Development.json</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/appsettings.json'>appsettings.json</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Program.cs'>Program.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
					<details>
						<summary><b>Controllers</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/AuthController.cs'>AuthController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/ProductsController.cs'>ProductsController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/UsersController.cs'>UsersController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/ApplicationServicesController.cs'>ApplicationServicesController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/RolesController.cs'>RolesController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/FilesController.cs'>FilesController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/AuthorizationEndpointsController.cs'>AuthorizationEndpointsController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/OrdersController.cs'>OrdersController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Controllers/BasketsController.cs'>BasketsController.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Configurations</b></summary>
						<blockquote>
							<details>
								<summary><b>ColumnWriters</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Configurations/ColumnWriters/UsernameColumnWriter.cs'>UsernameColumnWriter.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>.config</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/.config/dotnet-tools.json'>dotnet-tools.json</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Properties</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Properties/serviceDependencies.ECommerceAPIAPI20230718135833 - Web Deploy.json'>serviceDependencies.ECommerceAPIAPI20230718135833 - Web Deploy.json</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Properties/launchSettings.json'>launchSettings.json</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Properties/serviceDependencies.json'>serviceDependencies.json</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
							<details>
								<summary><b>ServiceDependencies</b></summary>
								<blockquote>
									<details>
										<summary><b>ECommerceAPIAPI20230718135833 - Web Deploy</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Properties/ServiceDependencies/ECommerceAPIAPI20230718135833 - Web Deploy/profile.arm.json'>profile.arm.json</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Properties/ServiceDependencies/ECommerceAPIAPI20230718135833 - Web Deploy/apis1.arm.json'>apis1.arm.json</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											</table>
										</blockquote>
									</details>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Filters</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Filters/RolePermissionFilter.cs'>RolePermissionFilter.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Extensions</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Presentation/ECommerceAPI.API/Extensions/ConfigureExceptionHandlerExtension.cs'>ConfigureExceptionHandlerExtension.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
				</blockquote>
			</details>
		</blockquote>
	</details>
	<details> <!-- Infrastructure Submodule -->
		<summary><b>Infrastructure</b></summary>
		<blockquote>
			<details>
				<summary><b>ECommerceAPI.Persistence</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/DesignTimeDbContextFactory.cs'>DesignTimeDbContextFactory.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/ServiceRegistration.cs'>ServiceRegistration.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/ECommerceAPI.Persistence.csproj'>ECommerceAPI.Persistence.csproj</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Configuration.cs'>Configuration.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
					<details>
						<summary><b>Migrations</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Migrations/ECommerceAPIDbContextModelSnapshot.cs'>ECommerceAPIDbContextModelSnapshot.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Migrations/20230718104956_Init.Designer.cs'>20230718104956_Init.Designer.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Migrations/20230718104956_Init.cs'>20230718104956_Init.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Services</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Services/AuthService.cs'>AuthService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Services/RoleService.cs'>RoleService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Services/UserService.cs'>UserService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Services/BasketService.cs'>BasketService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Services/AuthorizationEndpointService.cs'>AuthorizationEndpointService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Services/ProductService.cs'>ProductService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Services/OrderService.cs'>OrderService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Properties</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Properties/launchSettings.json'>launchSettings.json</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Repositories</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/WriteRepository.cs'>WriteRepository.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/ReadRepository.cs'>ReadRepository.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
							<details>
								<summary><b>BasketItem</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/BasketItem/BasketItemReadRepository.cs'>BasketItemReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/BasketItem/BasketItemWriteRepository.cs'>BasketItemWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Customer</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Customer/CustomerReadRepository.cs'>CustomerReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Customer/CustomerWriteRepository.cs'>CustomerWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>ProductImageFile</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/ProductImageFile/ProductImageFileReadRepository.cs'>ProductImageFileReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/ProductImageFile/ProductImageFileWriteRepository.cs'>ProductImageFileWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>CompletedOrder</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/CompletedOrder/CompletedOrderWriteRepository.cs'>CompletedOrderWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/CompletedOrder/CompletedOrderReadRepository.cs'>CompletedOrderReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Product</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Product/ProductWriteRepository.cs'>ProductWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Product/ProductReadRepository.cs'>ProductReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Endpoint</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Endpoint/EndpointWriteRepository.cs'>EndpointWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Endpoint/EndpointReadRepository.cs'>EndpointReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Order</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Order/OrderReadRepository.cs'>OrderReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Order/OrderWriteRepository.cs'>OrderWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Menu</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Menu/MenuWriteRepository.cs'>MenuWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Menu/MenuReadRepository.cs'>MenuReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Basket</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Basket/BasketWriteRepository.cs'>BasketWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/Basket/BasketReadRepository.cs'>BasketReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>File</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/File/FileWriteRepository.cs'>FileWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/File/FileReadRepository.cs'>FileReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>InvoiceFile</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/InvoiceFile/InvoiceFileWriteRepository.cs'>InvoiceFileWriteRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Repositories/InvoiceFile/InvoiceFileReadRepository.cs'>InvoiceFileReadRepository.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Contexts</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Persistence/Contexts/ECommerceAPIDbContext.cs'>ECommerceAPIDbContext.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
				</blockquote>
			</details>
			<details>
				<summary><b>ECommerceAPI.SignalR</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.SignalR/ECommerceAPI.SignalR.csproj'>ECommerceAPI.SignalR.csproj</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.SignalR/ServiceRegistration.cs'>ServiceRegistration.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.SignalR/RecieveFunctionNames.cs'>RecieveFunctionNames.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.SignalR/HubRegistration.cs'>HubRegistration.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
					<details>
						<summary><b>Hubs</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.SignalR/Hubs/ProductHub.cs'>ProductHub.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.SignalR/Hubs/OrderHub.cs'>OrderHub.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>HubServices</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.SignalR/HubServices/ProductHubService.cs'>ProductHubService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.SignalR/HubServices/OrderHubService.cs'>OrderHubService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
				</blockquote>
			</details>
			<details>
				<summary><b>ECommerceAPI.Infrastructure</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/ServiceRegistration.cs'>ServiceRegistration.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/ECommerceAPI.Infrastructure.csproj'>ECommerceAPI.Infrastructure.csproj</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
					<details>
						<summary><b>Enums</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Enums/StorageType.cs'>StorageType.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Services</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/MailService.cs'>MailService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/FileService.cs'>FileService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/QRCodeService.cs'>QRCodeService.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
							<details>
								<summary><b>Configuration</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/Configuration/ApplicationService.cs'>ApplicationService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Token</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/Token/TokenHandler.cs'>TokenHandler.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Storage</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/Storage/StorageService.cs'>StorageService.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/Storage/Storage.cs'>Storage.cs</a></b></td>
										<td><code>❯ REPLACE-ME</code></td>
									</tr>
									</table>
									<details>
										<summary><b>Azure</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/Storage/Azure/AzureStorage.cs'>AzureStorage.cs</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											</table>
										</blockquote>
									</details>
									<details>
										<summary><b>Local</b></summary>
										<blockquote>
											<table>
											<tr>
												<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Services/Storage/Local/LocalStorage.cs'>LocalStorage.cs</a></b></td>
												<td><code>❯ REPLACE-ME</code></td>
											</tr>
											</table>
										</blockquote>
									</details>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Filters</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/Filters/ValidationFilter.cs'>ValidationFilter.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>StaticServices</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/Emir-Khan/ECommerceAPI/blob/master/Infrastructure/ECommerceAPI.Infrastructure/StaticServices/RenameHelper.cs'>RenameHelper.cs</a></b></td>
								<td><code>❯ REPLACE-ME</code></td>
							</tr>
							</table>
						</blockquote>
					</details>
				</blockquote>
			</details>
		</blockquote>
	</details>
</details>

---
##  Getting Started

###  Prerequisites

Before getting started with ECommerceAPI, ensure your runtime environment meets the following requirements:

- **Programming Language:** CSharp
- **Package Manager:** Nuget


###  Installation

Install ECommerceAPI using one of the following methods:

**Build from source:**

1. Clone the ECommerceAPI repository:
```sh
❯ git clone https://github.com/Emir-Khan/ECommerceAPI
```

2. Navigate to the project directory:
```sh
❯ cd ECommerceAPI
```

3. Install the project dependencies: &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet restore
```




###  Usage
Run ECommerceAPI using the following command: &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet run
```





---
##  Project Roadmap

- [X] **`Task 1`**: <strike>Update to .Net 9.0</strike>
- [ ] **`Task 2`**: Redis Caching.
- [ ] **`Task 3`**: Soft Delete.
