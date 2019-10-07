import React from 'react'
import { Grid, GridColumn, List } from 'semantic-ui-react'
import { IActivity } from '../../../app/models/activity';
import ActivtyList from './ActivtyList';

interface IProps {
    activities: IActivity[]
}

const ActivityDashboard: React.FC<IProps> = ({activities}) => {
    return (
      <Grid>
        <Grid.Column width={10}>
          <List>
              <ActivtyList activities={activities}/>
            {/* {activities.map(activity => (
              <List.Item key={activity.id}>{activity.title}</List.Item>
            ))} */}
          </List>
        </Grid.Column>
      </Grid>
    );
}

export default ActivityDashboard
