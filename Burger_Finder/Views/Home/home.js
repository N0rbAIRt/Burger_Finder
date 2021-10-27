import React from "react";
import ReactDOM from "react-dom";
import { Flex, Box } from "rebass";
import {
    TextInputField,
    Text,
    Pane,
    Heading,
    Button,
    Link
} from "evergreen-ui";

function App() {
    return (
        <div>
            <Box>
                <Pane
                    background="tint1"
                    border="default"
                    display="flex"
                    padding={16}
                    marginBottom={30}
                >
                    <Pane flex={1} alignItems="center" display="flex">
                        <Heading size={600}>Logo</Heading>
                    </Pane>
                    <Pane>
                        <Link marginRight={16}>Blog</Link>
                        <Link>About</Link>
                    </Pane>
                </Pane>
            </Box>
            <Flex justifyContent="center">
                <Box width={[1, 1 / 2, 1 / 3]}>
                    <Pane
                        background="tint2"
                        display="flex"
                        flexWrap="wrap"
                        justifyContent="center"
                        flexDirection="column"
                        padding={20}
                    >
                        <Heading size={700} textAlign="center" paddingBottom="2rem">
                            Log in
                        </Heading>
                        <TextInputField required label="Username" />
                        <TextInputField required type="password" label="Password" />
                        <Button appearance="primary" justifyContent="center">
                            Log in
                        </Button>
                        <Text textAlign="center" marginTop="2rem">
                            Forgot your password? <Link href="#"> Reset your password</Link>
                        </Text>
                        <Text textAlign="center">
                            Don't have an account? <Link href="#">Sign up</Link>
                        </Text>
                    </Pane>
                </Box>
            </Flex>
        </div>
    );
}

const rootElement = document.getElementById("root");
ReactDOM.render(<App />, rootElement);

